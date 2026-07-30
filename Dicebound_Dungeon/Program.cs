/*********************************************************************
 * Name: Clark Batungbakal
 * GitHub: C1ark22
 * Project: Dicebound Dungeon
 * 
 * File: <Program.cs>
 * 
 * Description: Dicebound Dungeon is a C# console-based adventure game 
 * in which players explore a dungeon and make decisions during combat, 
 * traps, and other encounters. A virtual 20-sided die determines the 
 * outcome of each action, with character bonuses affecting the chance 
 * of success. Players must manage their health, collect rewards, and 
 * survive the dungeon to win.
 * 
 **********************************************************************/

namespace Dicebound_Dungeon
{
    internal class Program
    {
        static int RollD20(Random random)
        {
            return random.Next(1, 21);
        }
        static void Main(string[] args)
        {
            // User picks a character class (Warrior, Mage, or Rogue)
            // Characters has class, health, attack, defense
            // Strength Bonus: Warrior has +2 to attack rolls, Mage has +2 to spellcasting rolls, Rogue has +2 to stealth rolls
            Character playerCharacter = PickYourCharacter();

            // Encounters Entering the dungeon
            DungeonRun(playerCharacter);

            // Enemies have name, health, attack, and defense
            // Roll a 20-sided die to determine the outcome of actions (combat, traps, etc.)
            // 1 = critical failure, 2-9 Failure, 10-19 = Success, 20 = critical success
            // Bandits, Skeletons are some of the enemies players may encounter and Dragons as the boss 


            
        }
        static Character PickYourCharacter()
        {
            // Prompt the user to choose a character class
            Console.WriteLine("Choose your character class:");
            Console.WriteLine("1. Warrior");
            Console.WriteLine("2. Mage");
            Console.WriteLine("3. Rogue");
            while (true)
            {
                // Read the user's choice
                string choice = Console.ReadLine();
                // Create a character based on the user's choice
                Character playerCharacter = null;
                switch (choice)
                {
                    case "1":
                        // Create a Warrior character
                        playerCharacter = new Character(Character.CharacterType.Warrior);
                        break;
                    case "2":
                        // Create a Mage character
                        playerCharacter = new Character(Character.CharacterType.Mage);
                        break;
                    case "3":
                        // Create a Rogue character
                        playerCharacter = new Character(Character.CharacterType.Rogue);
                        break;
                    default:
                        // Exit the method if the choice is invalid
                        Console.WriteLine("Invalid choice. Please select 1, 2, or 3.");
                        continue;
                }
                // Display the chosen character's details (name, health, attack, defense, strengthBonus, defenseBonus, crit Bonus)
                Console.WriteLine($"You have chosen: {playerCharacter.CharacterClass}");
                Console.WriteLine($"Health: {playerCharacter.Health}");
                Console.WriteLine($"Attack: {playerCharacter.Attack}");
                Console.WriteLine($"Crit Bonus: {playerCharacter.CritBonus}");
                return playerCharacter;
            }
        }
        static void DungeonRun(Character playerCharacter)
        {
            Console.WriteLine("You entered the dungeon....");

            List<Encounter> encounterList = new List<Encounter>();
            // Encounter 1: Bandit Ambush
            // Encounter 2: You tripped if less than 1 you died
            // Encounter 3: Skeleton Ambush
            // Encounter 4: Treasure Chest
            // Encounter 5: Dragon Boss Fight
            Encounter banditAmbush = new Encounter(
                "Bandit Ambush",
                "A bandit is blocking your path",
                9,
                "You successfully killed the bandit",
                "You failed on killing the bandit and you died"
                );
            Encounter rock = new Encounter(
                "You tripped on a rock",
                "You were walking and you didn't notice the big rock",
                2,
                "You were able to keep your balance and moved on..",
                "You tripped on a rock and died"
                );
            Encounter skeletonAmbush = new Encounter(
                "Skeleton Spotted",
                "A skeleton is blocking your path",
                5,
                "You successfully deafeated the skeleton",
                "You failed and died"
                );
            Encounter treasureChest = new Encounter(
                "You found a treasure chest",
                "It may contain a treasure to give you a bonus",
                14,
                "You received a potion that healed you",
                "The chest was empty"
                );
            Encounter finalBoss = new Encounter(
                "Dragon has been spotted",
                "The legend says that nobody has beaten such creature",
                20,
                "You became a hero after deafeating the dragon",
                "You died"
                );
            encounterList.Add(banditAmbush);
            encounterList.Add(rock);
            encounterList.Add(skeletonAmbush);
            encounterList.Add(treasureChest);
            encounterList.Add(finalBoss);

            Random random = new Random();
            int diceRoll = RollD20(random);

            int currentEncounterIndex = 0;

            while (playerCharacter.Health > 0 && currentEncounterIndex < encounterList.Count) 
            {
                Encounter currentEncounter = encounterList[currentEncounterIndex];

                Console.WriteLine(currentEncounter);

                // get current enemy
                // if its an enemy encounter
                    // combat happens here
                    // while player health is over 0 and enemy health > 0
                // else Roll against the encounter difficulty
                // move to the next encounter if the player survives

                currentEncounterIndex++;
            }



        }
    }
}
