using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

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
        private string SaveFile { get; set; }
        private bool JumpSelectionMode { get; set; }
        private DialogueNode.Choice JumpFrom { get; set; }

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

            AddTreeNode("Start");
            SetTitle(false);
        }

        private void AddCharacter(string name) {
            AddCharacter(new Character(name));
        }

        private void AddCharacter(Character c) {
            Character.Characters[c.Name] = c; // add to static list to keep references
            CharacterColumn.Items.Add(c.Name);
            SetTitle(true);
        }

        private DialogueNode AddTreeNode(string name, TreeNode root = null) {
            TreeNode added;
            if (root is null) {
                added = TreeView.Nodes.Add(name);
            } else {
                added = root.Nodes.Add(name);
            }
            var newNode = new DialogueNode(added);
            added.Tag = new TreeTag(newNode, false);
            return newNode;
        }

        private void LoadDialogueNode(TreeNode treeNode) {
            // disable the tables so when cellEnter is triggered, it doesn't start editing
            DialogueTable.Enabled = false;
            ChoiceTable.Enabled = false;
            DialogueTable.Rows.Clear();
            ChoiceTable.Rows.Clear();
            var node = GetNode(treeNode);
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
            if (!JumpSelectionMode) { // jumping keeps tables disabled until a tree node is selected for jumping
                DialogueTable.Enabled = true;
                ChoiceTable.Enabled = true;
            }
            CurrentTreeNode = treeNode;
            CurrentNode = node;
        }

        private void SetTitle(bool changedStatus) {
            string fileName = string.IsNullOrWhiteSpace(SaveFile) ? "(New File)" : SaveFile;
            string status = changedStatus ? "*" : "";
            Text = $"Dialogue Creator - {fileName}{status}";
        }

        private async void ComboBox_SelectionChangeCommitted(object sender, EventArgs e) {
            ComboBox comboBox = (ComboBox) sender;
            comboBox.SelectionChangeCommitted -= ComboBox_SelectionChangeCommitted; // undo the event binding
            // shift selected column over to dialogue column
            Console.WriteLine(comboBox.SelectedItem);
            await Task.Delay(1); // ms
            DialogueTable.CurrentCell = DialogueTable[DialogueColumn.Index, DialogueTable.CurrentCell.RowIndex];
            SetTitle(true);
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
            SetTitle(true);
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
            SetTitle(true);
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

        private void SaveToFile() {
            var container = new JsonDialogueContainer(GetNode(TreeView.Nodes[0]), Character.Characters.Values);
            string jsonOut = JsonConvert.SerializeObject(container);
            System.IO.File.WriteAllText(SaveFile, jsonOut);
            SetTitle(false);
        }

        private void CopyDialogueToTree(TreeNode treeRoot, DialogueNode root, bool isRef = false) {
            treeRoot.Tag = new TreeTag(root, isRef);
            root.TreeNode = treeRoot;
            foreach (var choice in root.Choices) {
                TreeNode added = treeRoot.Nodes.Add(choice.Text);
                CopyDialogueToTree(added, choice.NextNode, choice.IsRef);
            }
        }

        private void LoadFromFile(string filePath) {
            // clear all contents
            Character.Characters.Clear();
            TreeView.Nodes.Clear();

            // load json
            string jsonIn = System.IO.File.ReadAllText(filePath);
            var container = JsonConvert.DeserializeObject<JsonDialogueContainer>(jsonIn);
            foreach (Character c in container.Characters) {
                AddCharacter(c);
            }
            CopyDialogueToTree(TreeView.Nodes.Add("Start"), container.Root);
            SetTitle(false);
        }

        private bool Save(bool saveAs) {
            if (saveAs || string.IsNullOrEmpty(SaveFile)) {
                var saveDialogue = new SaveFileDialog {
                    Filter = "Json (*.json)|*.json",
                    RestoreDirectory = true,
                    Title = "Save As"
                };
                if (saveDialogue.ShowDialog() == DialogResult.OK) {
                    SaveFile = saveDialogue.FileName;
                    SaveToFile();
                    return true;
                } else return false;
            } else {
                SaveToFile();
                return true;
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e) {
            Save(false);
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e) {
            Save(true);
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e) {
            var openDialogue = new OpenFileDialog {
                Filter = "Json (*.json)|*.json",
                RestoreDirectory = true,
                Title = "Open File"
            };
            if (openDialogue.ShowDialog() == DialogResult.OK) {
                SaveFile = openDialogue.FileName;
                LoadFromFile(SaveFile);
            }
        }

        private void Clear() {
            SaveFile = null;
            Character.Characters.Clear();
            TreeView.Nodes.Clear();
            AddTreeNode("Start");
            SetTitle(false);
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e) {
            Save(false);
            Clear();
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
                TraverseTreePreorder(TreeView.TopNode, treeNode => {
                    foreach (var dialogue in (GetNode(treeNode).Dialogues)) {
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
            var lastNode = CurrentNode;
            LoadDialogueNode(e.Node);
            if (JumpSelectionMode && lastNode == CurrentNode) { // clicked on same node again
                // this may accidentally destroy unreferenced nodes after assigning NextNode, so check first
                int destroyCount = JumpFrom.TreeNode.GetNodeCount(true);
                string alert = "";
                if (destroyCount > 0) {
                    alert = $"This will destroy the {destroyCount} existing node{AddS(destroyCount)} under the choice.";
                }
                var result = MessageBox.Show($"Choosing '{JumpFrom.Text}' will jump as if choosing '{CurrentTreeNode.Text}'{alert} Continue?", "Jump?", 
                    MessageBoxButtons.YesNoCancel, alert == "" ? MessageBoxIcon.Question : MessageBoxIcon.Warning);
                if (result == DialogResult.Yes || result == DialogResult.Cancel) {
                    if (result == DialogResult.Yes) {
                        JumpFrom.NextNode = CurrentNode;
                        JumpFrom.IsRef = true;
                        JumpFrom.TreeNode.Tag = new TreeTag(CurrentNode, true);
                        JumpFrom.TreeNode.ForeColor = Color.Blue; // TODO: let them undo this
                        // TODO: color blue if ref on load
                        // TODO: undo orange background if node has been selected
                    }
                    JumpSelectionMode = false;
                    // disable all tables until they select a node from the tree
                    DialogueTable.Enabled = true;
                    ChoiceTable.Enabled = true;
                    TreeView.Cursor = Cursors.Default;
                }
            }
        }

        private void TreeView_MouseUp(object sender, MouseEventArgs e) {
            TreeNode mouseNode = TreeView.GetNodeAt(e.Location);
            if (e.Button == MouseButtons.Right) {
                if (mouseNode is null) {
                    TreeContextMenuStrip.Show(TreeView, e.Location);
                } else {
                    TreeView.SelectedNode = mouseNode;
                    TreeItemContextMenuStrip.Show(TreeView, e.Location);
                }
            }
        }

        private void DialogueTable_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e) {
            if (CurrentNode is null || e.RowIndex == 0 || !DialogueTable.Enabled) return;
            CurrentNode.Dialogues.Add(new DialogueNode.Dialogue());
            SetTitle(true);
        }

        private void ChoiceTable_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e) {
            if (CurrentNode is null || e.RowIndex == 0 || !ChoiceTable.Enabled) return;
            DialogueNode addedNode = AddTreeNode("-", CurrentTreeNode);
            DialogueNode.Choice newChoice = new DialogueNode.Choice(addedNode.TreeNode, false);
            CurrentNode.Choices.Add(newChoice);
            newChoice.NextNode = addedNode;
            CurrentTreeNode.Expand();
            SetTitle(true);
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
                SetTitle(true);
            }
        }
        
        private static string AddS(int count) {
            return count == 1 ? "" : "s";
        }

        private DialogueNode GetNode(TreeNode treeNode) {
            return ((TreeTag) treeNode.Tag).Node;
        }

        private bool DeleteChoice(TreeNode deleteNode, int rowIndex) {
            // delete choice row and tree
            int destroyCount = deleteNode.GetNodeCount(true) + 1; // children + node itself
            DialogResult deleteChoice;
            if (destroyCount <= 1) { // only one node, don't ask
                deleteChoice = DialogResult.OK;
            } else {
                deleteChoice = MessageBox.Show($"Delete '{deleteNode.Text}'? This will destroy the entire decision tree! " +
                    $"({destroyCount} node{AddS(destroyCount)}!) Proceed?",
                    "Delete choice?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            if (deleteChoice == DialogResult.OK) {
                var deleteDNode = GetNode(deleteNode);
                int references = FindReferences(deleteDNode).Count;
                if (references > 0) {
                    MessageBox.Show($"Cannot delete. Found {references} reference{AddS(references)} to this node. Delete or unlink them first.", 
                        "References found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                var treeParent = deleteNode.Parent;
                var dialogueParent = GetNode(treeParent);
                dialogueParent.Choices.RemoveAt(rowIndex); // del data
                treeParent.Nodes.RemoveAt(rowIndex); // (scary), del tree
                SetTitle(true);
                return true; 
            } else return false;
        }

        private void ChoiceTable_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            string colName = GetColButtonPress(ChoiceTable, e);
            if (CurrentNode is null) return;
            if (colName == DeleteChoiceColumn.Name) {
                DeleteChoice(CurrentTreeNode.Nodes[e.RowIndex], e.RowIndex);
                ChoiceTable.Rows.RemoveAt(e.RowIndex); // del visual row
            } else if (colName == ChooseColumn.Name) {
                // navigate into the choice
                TreeView.SelectedNode = CurrentTreeNode.Nodes[e.RowIndex]; // invokes Load
            }
        }

        private void DeleteChoiceToolStripMenuItem_Click(object sender, EventArgs e) {
            if (CurrentTreeNode.Parent != null) { // not root node, not jumping
                DeleteChoice(CurrentTreeNode, CurrentTreeNode.Parent.Nodes.IndexOf(CurrentTreeNode));
            }
        }

        private void ExpandAllToolStripMenuItem_Click(object sender, EventArgs e) {
            CurrentTreeNode.ExpandAll();
        }

        private void CollapseAllToolStripMenuItem_Click(object sender, EventArgs e) {
            CurrentTreeNode.Collapse(false); // collapse children too
        }

        private void ChoiceTable_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e) {
            var row = ChoiceTable.Rows[e.RowIndex];
            if (row.IsNewRow || !ChoiceTable.Enabled) return;
            if (e.Button == MouseButtons.Right) {
                JumpFrom = CurrentNode.Choices[e.RowIndex];
                ChoiceContextMenuStrip.Show(e.Location);
            }
        }

        private void JumpToolStripMenuItem_Click(object sender, EventArgs e) {
            JumpSelectionMode = true;
            // disable all tables until they select a node from the tree
            DialogueTable.Enabled = false;
            ChoiceTable.Enabled = false;
            TreeView.Cursor = Cursors.Hand;
        }

        private List<TreeNode> FindReferences(DialogueNode refNode, bool onlyExternal = true) {
            var foundNodes = new List<TreeNode>();
            TraverseTreePreorder(TreeView.TopNode, treeNode => {
                var node = GetNode(treeNode);
                if (node == refNode && (!onlyExternal || treeNode != refNode.TreeNode)) foundNodes.Add(treeNode);
            });
            return foundNodes;
        }

        private void FindReferencesToolStripMenuItem_Click(object sender, EventArgs e) {
            foreach (var treeNode in FindReferences(CurrentNode)) {
                treeNode.BackColor = Color.Orange;
            }

        }
    }
}
