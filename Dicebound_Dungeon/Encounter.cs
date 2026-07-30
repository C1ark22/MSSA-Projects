using System;
using System.Collections.Generic;
using System.Text;

namespace Dicebound_Dungeon
{
    public class Encounter
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Difficulty { get; set; }
        public string Succeeded { get; set; }
        public string Failed { get; set; }

        public Encounter(string name, string description, int difficulty, string succeeded, string failed) 
        { 
            Name = name;
            Description = description;
            Difficulty = difficulty;
            Succeeded = succeeded;
            Failed = failed;
        }
    }
}
