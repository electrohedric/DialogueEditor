using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogueCreator {
    class TreeTag {
        public DialogueNode Node { get; set; }
        public bool IsReference { get; set; }

        public TreeTag(DialogueNode node, bool isRef) {
            Node = node;
            IsReference = isRef;
        }
    }
}
