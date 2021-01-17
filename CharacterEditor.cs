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
    public partial class CharacterEditor : Form {

        public bool Canceled { get; set; }

        public CharacterEditor(IEnumerable<string> characters) {
            InitializeComponent();

            CharacterBox.Text = "";
            foreach (string character in characters) {
                CharacterBox.Text += character + "\r\n";
            }
            CharacterBox.Select(CharacterBox.Text.Length, 0);

            Canceled = true; // if they X out, this is the default
        }

        public HashSet<string> GetCharacterNames() {
            var charNames = new HashSet<string>();
            foreach (string line in CharacterBox.Lines) {
                string trimmed = line.Trim();
                if (trimmed != "") charNames.Add(trimmed);
            }
            return charNames;
        }

        private void OkButton_Click(object sender, EventArgs e) {
            Canceled = false;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e) {
            Canceled = true;
            Close();
        }
    }
}
