using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogueCreator {
    public partial class DialogueCreatorForm : Form {

        readonly DataGridViewComboBoxColumn CharacterColumn;
        readonly DataGridViewTextBoxColumn DialogueColumn;
        readonly DataGridViewButtonColumn DeleteConvoColumn;

        readonly DataGridViewButtonColumn ChooseColumn;
        readonly DataGridViewTextBoxColumn DialogueChoiceColumn;
        readonly DataGridViewButtonColumn DeleteChoiceColumn;

        private DialogueNode CurrentNode { get; set; }
        private TreeNode CurrentTreeNode { get; set; }

        public DialogueCreatorForm() {
            InitializeComponent();

            CharacterColumn = (DataGridViewComboBoxColumn) DialogueTable.Columns["CharacterSelect"];
            DialogueColumn = (DataGridViewTextBoxColumn) DialogueTable.Columns["ConvDialogue"];
            DeleteConvoColumn = (DataGridViewButtonColumn) DialogueTable.Columns["DeleteConvoRowButton"];

            ChooseColumn = (DataGridViewButtonColumn) ChoiceTable.Columns["ChooseButton"];
            DialogueChoiceColumn = (DataGridViewTextBoxColumn) ChoiceTable.Columns["ChoiceDialogue"];
            DeleteChoiceColumn = (DataGridViewButtonColumn) ChoiceTable.Columns["DeleteChoiceRowButton"];

            DialogueTable.RowTemplate.MinimumHeight = 50;
            ChoiceTable.RowTemplate.MinimumHeight = 50;
            DialogueTable.Rows.Clear();
            ChoiceTable.Rows.Clear();

            AddCharacter("Socrates");
            AddCharacter("Player");

            AddTreeNode("Start");
            
        }

        private void AddCharacter(string name) {
            Character.AddCharacter(name);
            CharacterColumn.Items.Add(name);
        }

        private void AddTreeNode(string name, TreeNode root = null) {
            TreeNode added;
            if (root is null) {
                added = TreeView.Nodes.Add(name);
            } else {
                added = root.Nodes.Add(name);
            }
            added.Tag = new DialogueNode();
        }

        private void LoadDialogueNode(TreeNode treeNode) {
            // disable the tables so when cellEnter is triggered, it doesn't start editing
            DialogueTable.Enabled = false;
            ChoiceTable.Enabled = false;
            DialogueTable.Rows.Clear();
            ChoiceTable.Rows.Clear();
            var node = (DialogueNode) treeNode.Tag;
            foreach (DialogueNode.Dialogue dialogue in node.Dialogues) {
                var row = DialogueTable.Rows[DialogueTable.Rows.Add()];
                row.Cells[CharacterColumn.Index].Value = dialogue.Speaker?.Name;
                row.Cells[DialogueColumn.Index].Value = dialogue.Text;
            }
            foreach (DialogueNode.Choice choice in node.Choices) {
                var row = ChoiceTable.Rows[ChoiceTable.Rows.Add()];
                row.Cells[DialogueChoiceColumn.Index].Value = choice.Text;
            }
            //DialogueTable.CurrentCell = DialogueTable.Rows[DialogueTable.Rows.Count - 1].Cells[DialogueColumn.Index];
            DialogueTable.CurrentCell = null;
            ChoiceTable.CurrentCell = null;
            DialogueTable.Enabled = true;
            ChoiceTable.Enabled = true;
            CurrentTreeNode = treeNode;
            CurrentNode = node;
        }

        private async void ComboBox_SelectionChangeCommitted(object sender, EventArgs e) {
            ComboBox comboBox = (ComboBox) sender;
            comboBox.SelectionChangeCommitted -= ComboBox_SelectionChangeCommitted; // undo the event binding
            // shift selected column over to dialogue column
            Console.WriteLine(comboBox.SelectedItem);
            await Task.Delay(1); // ms
            DialogueTable.CurrentCell = DialogueTable[DialogueColumn.Index, DialogueTable.CurrentCell.RowIndex];
        }

        private void Table_CellEnter(object sender, DataGridViewCellEventArgs e) {
            var table = (DataGridView) sender;
            if (!table.Enabled) return; // editing something else
            table.BeginEdit(false); // so the user doesn't have to click twice to edit a cell
            if (table.EditingControl is ComboBox comboBox) {
                comboBox.DroppedDown = true;
                comboBox.SelectionChangeCommitted += ComboBox_SelectionChangeCommitted; // when they select an item
            }
        }

        private void SaveDialogue(int rowIndex) {
            if (rowIndex == -1 || CurrentNode is null || !DialogueTable.Enabled) return;
            DialogueTable.Enabled = false;
            DialogueTable.EndEdit();
            DialogueTable.ClearSelection();
            DialogueTable.Enabled = true;
            var row = DialogueTable.Rows[rowIndex]; // row already exists
            if (row.IsNewRow) return; // dont care, can't save that
            var dialogue = CurrentNode.Dialogues[rowIndex];
            string chosenCharacter = (string) row.Cells[CharacterColumn.Index].Value;
            if (chosenCharacter != null) dialogue.Speaker = Character.Characters[chosenCharacter];
            dialogue.Text = (string) row.Cells[DialogueColumn.Index].Value;
            Console.WriteLine("Saved dialogue " + rowIndex + " to " + CurrentNode);
        }

        private void SaveChoice(int rowIndex) {
            if (rowIndex == -1 || CurrentNode is null || !ChoiceTable.Enabled) return;
            ChoiceTable.Enabled = false;
            ChoiceTable.EndEdit();
            ChoiceTable.ClearSelection();
            ChoiceTable.Enabled = true;
            var row = ChoiceTable.Rows[rowIndex]; // row already exists
            if (row.IsNewRow) return; // dont care, can't save that
            var choice = CurrentNode.Choices[rowIndex];
            choice.Text = (string) row.Cells[DialogueChoiceColumn.Index].Value;
            CurrentTreeNode.Nodes[rowIndex].Text = choice.Text;
            Console.WriteLine("Saved choice " + rowIndex + " to " + CurrentNode);
        }

        private void DialogueTable_CellLeave(object sender, DataGridViewCellEventArgs e) {
            SaveDialogue(e.RowIndex);
        }

        private void DialogueTable_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
            SaveDialogue(e.RowIndex);
        }

        private void ChoiceTable_CellLeave(object sender, DataGridViewCellEventArgs e) {
            SaveChoice(e.RowIndex);
        }

        private void ChoiceTable_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
            SaveChoice(e.RowIndex);
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void TraverseTreePreorder(TreeNode root, Action<TreeNode> action) {
            action(root);
            foreach (TreeNode node in root.Nodes) {
                TraverseTreePreorder(node, action);
            }
        }

        private void CharactersToolStripMenuItem_Click(object sender, EventArgs e) {
            var oldChars = new HashSet<string>(Character.Characters.Keys);
            var charEditor = new CharacterEditor(Character.Characters.Keys);
            charEditor.ShowDialog(this);
            if (charEditor.Canceled) return;

            var newChars = charEditor.GetCharacterNames();
            var addedChars = new HashSet<string>(newChars);
            addedChars.ExceptWith(oldChars);
            var removedChars = new HashSet<string>(oldChars);
            removedChars.ExceptWith(newChars);

            // possible renaming characters
            if (removedChars.Count > 0 && addedChars.Count > 0) {
                // for every renamed character, we must remove it from both lists
                var renameForm = new RenameCharacterForm(removedChars, addedChars);
                renameForm.ShowDialog(this);
                if (renameForm.Canceled) return;
                DialogueTable.Enabled = false;
                DialogueTable.Rows.Clear();
                foreach (var x in renameForm.GetActions()) {
                    string renameFrom = x.Key;
                    string renameTo = x.Value;
                    if (renameTo != "") { // being renamed
                        addedChars.Remove(renameTo);
                        removedChars.Remove(renameFrom);
                        // pop character, rename it, add it back to characters under the new name
                        var renamingChar = Character.Characters[renameFrom];
                        Character.Characters.Remove(renameFrom);
                        renamingChar.Name = renameTo; // will update the combobox
                        Character.Characters[renameTo] = renamingChar;
                        // replace combobox item
                        CharacterColumn.Items.Remove(renameFrom);
                        CharacterColumn.Items.Add(renameTo);
                    }
                    // characters which are empty (need to delete) will be left in the removedChars for below
                }
            }
            // deleting old characters
            if (removedChars.Count > 0) {
                // go down the tree and set all characters which were removed to null
                TraverseTreePreorder(TreeView.TopNode, node => {
                    foreach (var dialogue in ((DialogueNode) node.Tag).Dialogues) {
                        if (removedChars.Contains(dialogue.Speaker.Name)) {
                            dialogue.Speaker = null;
                        }
                    }
                });
                foreach (var remName in removedChars) {
                    // remove character from dict and from the combobox
                    Character.Characters.Remove(remName);
                    CharacterColumn.Items.Remove(remName);
                }
            }
            // adding new characters
            if (addedChars.Count > 0) {
                foreach (var character in addedChars) {
                    AddCharacter(character);
                }
            }

            LoadDialogueNode(CurrentTreeNode); // reload the node to show any changes to characters
        }

        private void TreeView_AfterSelect(object sender, TreeViewEventArgs e) {
            LoadDialogueNode(e.Node);
        }

        private void TreeView_MouseUp(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right) {
                TreeContextMenuStrip.Show(TreeView, e.Location);
            }
        }

        private void DialogueTable_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e) {
            if (CurrentNode is null || e.RowIndex == 0 || !DialogueTable.Enabled) return;
            CurrentNode.Dialogues.Add(new DialogueNode.Dialogue());
            Console.WriteLine("Added dialogue " + (e.RowIndex - 1));
        }

        private void ChoiceTable_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e) {
            if (CurrentNode is null || e.RowIndex == 0 || !ChoiceTable.Enabled) return;
            CurrentNode.Choices.Add(new DialogueNode.Choice());
            AddTreeNode("-", CurrentTreeNode);
            CurrentTreeNode.Expand();
            Console.WriteLine("Added choice " + (e.RowIndex - 1));
        }

        private string GetColButtonPress(DataGridView table, DataGridViewCellEventArgs e) {
            if (table[e.ColumnIndex, e.RowIndex] is DataGridViewButtonCell && !table.Rows[e.RowIndex].IsNewRow) { // button clicked, not new row
                return table.Columns[e.ColumnIndex].Name; // column name
            }
            return null;
        }

        private void DialogueTable_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            string colName = GetColButtonPress(DialogueTable, e);
            if (CurrentNode is null) return;
            if (colName == DeleteConvoColumn.Name) {
                // delete the dialogue row
                DialogueTable.Rows.RemoveAt(e.RowIndex);
                CurrentNode.Dialogues.RemoveAt(e.RowIndex);
                Console.WriteLine("Removed dialogue " + e.RowIndex);
            }
        }

        private void ChoiceTable_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            string colName = GetColButtonPress(ChoiceTable, e);
            if (CurrentNode is null) return;
            if (colName == DeleteChoiceColumn.Name) {
                // delete choice row and tree
                DialogResult deleteChoice = MessageBox.Show("This will destroy the entire decision tree! Proceed?",
                    "Delete choice?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (deleteChoice == DialogResult.OK) {
                    CurrentNode.Choices.RemoveAt(e.RowIndex); // -data
                    CurrentTreeNode.Nodes.RemoveAt(e.RowIndex); // scary, -tree
                    ChoiceTable.Rows.RemoveAt(e.RowIndex); // -row
                    Console.WriteLine("Removed choice " + e.RowIndex);
                }
            } else if (colName == ChooseColumn.Name) {
                // navigate into the choice
                TreeView.SelectedNode = CurrentTreeNode.Nodes[e.RowIndex]; // invokes Load
            }
        }
    }
}
