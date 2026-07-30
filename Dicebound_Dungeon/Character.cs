using System;
using System.Collections.Generic;
using System.Text;

namespace Dicebound_Dungeon
{
    public class Character
    {
        public enum CharacterType
        {
            Warrior,
            Mage,
            Rogue
        }
        public CharacterType CharacterClass { get; set; }
        public int Health { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int CritBonus { get; set; }
        
        public Character(CharacterType characterType)
        {
            CharacterClass = characterType;

            switch (characterType)
            {
                case CharacterType.Warrior:
                    Health = 45;
                    Attack = 10;
                    Defense = 4;
                    CritBonus = 0;
                    break;
                case CharacterType.Mage:
                    Health = 30;
                    Attack = 4;
                    Defense = 2;
                    CritBonus = 4;
                    break;
                case CharacterType.Rogue:
                    Health = 35;
                    Attack = 6;
                    Defense = 3;
                    CritBonus = 3;
                    break;
            }

        }
    }
}
