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
    public partial class RenameCharacterForm : Form {

        const int oldCharColumn = 0;
        const int actionColumn = 1;

        public bool Canceled { get; set; }

        private Dictionary<string, ComboBox> OptionBoxes { get; set; }

        public RenameCharacterForm(IEnumerable<string> toRemove, IEnumerable<string> renameOptions) {
            InitializeComponent();
            OptionBoxes = new Dictionary<string, ComboBox>();

            var labelFont = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            var comboFont = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);

            var comboItems = new List<object> { new { Text = "<Delete>", Value = "" }}; // always option to delete, rename to "" = delete
            foreach (var rename in renameOptions) {
                comboItems.Add(new { Text = "Rename to " + rename, Value = rename });
            }

            renameTable.SuspendLayout();

            foreach (var remove in toRemove) {
                // label with the old character name
                Label charLabel = new Label {
                    Text = remove,
                    Font = labelFont,
                    Anchor = AnchorStyles.None,
                    TextAlign = ContentAlignment.MiddleCenter
                };

                // combobox with delete and every new existing character as choices
                ComboBox optionsBox = new ComboBox {
                    DropDownStyle = ComboBoxStyle.DropDownList,
                    Font = comboFont,
                    Anchor = AnchorStyles.Left | AnchorStyles.Right,
                    DisplayMember = "Text",
                    ValueMember = "Value",
                    DataSource = comboItems
                };
                OptionBoxes[remove] = optionsBox;

                renameTable.RowCount++;
                renameTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
                renameTable.Controls.Add(charLabel, oldCharColumn, renameTable.RowCount - 1);
                renameTable.Controls.Add(optionsBox, actionColumn, renameTable.RowCount - 1);
            }

            renameTable.ResumeLayout();

            Canceled = true; // default if X is clicked
        }

        public IEnumerable<KeyValuePair<string, string>> GetActions() {
            foreach (var option in OptionBoxes) {
                var pair = new KeyValuePair<string, string>(option.Key, (string) option.Value.SelectedValue);
                yield return pair;
            }
        }

        private void OkButton_Click(object sender, EventArgs e) {
            foreach (var x in OptionBoxes) {
                if (x.Value.SelectedItem is null) return;
            }
            Canceled = false;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e) {
            Canceled = true;
            Close();
        }
    }
}
