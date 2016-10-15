using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace OnlineGame
{
    public interface Skill
    {
        // The amount of energy consumed by the skill.
        int AmountOfMagic { get; }

        // Number of items of an attribute added or removed by the skill.
        int ChangeOfAttribute { get; }

        // Duration of effect  caused by the skill. If the skill is applying instantly, this value is 0.
        int TimeOfAction { get; }

        int Cooldown { get; }

        DateTime TimeOfLastUse { get; }

        // Attribute which is increased or decreased by the skill.
        Attribute TargetAttribute { get; }

        // Charcter that has this skill.
        Character Owner { get; }


        // Method which chcked the probability of using this skill and apply changes to an attribute.
        // If TimeOfAction is not 0 this method adds new effect to the character.
        // Method returns true if the skill is used and false otherwise.
        bool Use(Character TargetCharacter);
    }

    // Examples of skills.

    public class Hit : Skill
    {
        public int AmountOfMagic { get; }
        public int ChangeOfAttribute { get; }
        public int TimeOfAction { get; }
        public int Cooldown { get; }
        public DateTime TimeOfLastUse { get; private set; }
        public Attribute TargetAttribute { get; }
        public Character Owner { get; }
        public Hit()
        {
            throw new NotImplementedException();
        }
        public bool Use(Character TargetCharacter)
        {
            throw new NotImplementedException();
        }
    }

    public class Trap : Skill
    {
        public int AmountOfMagic { get; }
        public int ChangeOfAttribute { get; }
        public int TimeOfAction { get; }
        public int Cooldown { get; }
        public DateTime TimeOfLastUse { get; private set; }
        public Attribute TargetAttribute { get; }
        public Character Owner { get; }
        public Trap()
        {
            throw new NotImplementedException();
        }

        // For example this method must decrease current value of speed and apply slowing effect to a character.
        public bool Use(Character TargetCharacter)
        {
            throw new NotImplementedException();
        }
    }
}
