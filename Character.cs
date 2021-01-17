using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogueCreator {
    public class Character {

        public static Dictionary<string, Character> Characters = new Dictionary<string, Character>();

        public string Name { get; set; }

        public Character(string name) {
            Name = name;
        }

        public static Character AddCharacter(string name) {
            var character = new Character(name);
            Characters[name] = character;
            return character;
        }

        public override string ToString() {
            return Name;
        }
    }
}
