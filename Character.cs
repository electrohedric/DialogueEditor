using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DialogueCreator {
    [JsonObject(IsReference = true)]
    public class Character {

        public static Dictionary<string, Character> Characters = new Dictionary<string, Character>();

        public string Name { get; set; }

        public Character(string name) {
            Name = name;
        }

        public override string ToString() {
            return Name;
        }
    }
}
