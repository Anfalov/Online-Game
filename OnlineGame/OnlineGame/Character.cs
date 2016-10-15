using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace OnlineGame
{
    public class Character
    {
        // Attributes of a character (Health, Magic and other).
        public ReadOnlyCollection<Attribute> Attributes { get; }

        // Skills of a character (like Hit).
        // Different characters can have different attributes and skills.
        public ReadOnlyCollection<Skill> Skills { get; }

        public List<Effect> AttachedEffects { get; }

        // Skills and attributes of character must be specified in the constructor.
        public Character()
        {
            throw new NotImplementedException();
        }

        // Function that updates character's attributes and effects every second.
        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
