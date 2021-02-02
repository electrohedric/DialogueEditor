using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DialogueCreator {

    /// <summary>
    /// Storage for root level nodes in json format. 
    /// Can store things like immutable properties about the dialogue (e.g. characters)
    /// </summary>
    public class JsonDialogueContainer {
        [JsonProperty(Order = 1)] // ensure references get saved first (makes json cleaner)
        public Character[] Characters { get; set; }
        [JsonProperty(Order = 2)]
        public DialogueNode Root { get; set; }

        public JsonDialogueContainer(DialogueNode root, IEnumerable<Character> characters) {
            Root = root;
            Characters = characters.ToArray();
        }
    }
}
