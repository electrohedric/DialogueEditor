﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogueCreator {
    public class DialogueNode {

        public List<Dialogue> Dialogues;
        public List<Choice> Choices;

        public DialogueNode() {
            Dialogues = new List<Dialogue>();
            Choices = new List<Choice>();
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