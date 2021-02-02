using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace DialogueCreator {

    [JsonObject(IsReference = true)]
    public class DialogueNode {

        public readonly List<Dialogue> Dialogues;
        public readonly List<Choice> Choices;

        [JsonIgnore]
        public TreeNode TreeNode { get; set; }

        public DialogueNode(TreeNode reference) {
            Dialogues = new List<Dialogue>();
            Choices = new List<Choice>();
            TreeNode = reference;
        }

        public class Dialogue {
            public Character Speaker { get; set; }

            public string Text { get; set; }

            public override string ToString() {
                return Speaker?.Name + ": " + Text;
            }
        }

        public class Choice {
            public string Text { get; set; }
            public DialogueNode NextNode { get; set; }
            public bool IsRef { get; set; }

            [JsonIgnore]
            public TreeNode TreeNode;

            public Choice(TreeNode reference, bool isRef) {
                TreeNode = reference;
                IsRef = isRef;
            }

            public override string ToString() {
                return Text;
            }
        }

        public override string ToString() {
            if (Dialogues.Count > 0) {
                return Dialogues[0].ToString();
            } else if (Choices.Count > 0) {
                return Choices[0].ToString();
            } else {
                return ":/ Nothing here";
            }
        }
    }
}
