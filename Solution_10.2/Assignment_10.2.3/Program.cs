//Write a program in C# Sharp to find a string that starts and ends with a specific character.
//Test Data :
//The cities are : 'ROME','LONDON','NAIROBI','CALIFORNIA','ZURICH','NEW DELHI','AMSTERDAM',
//  'ABU DHABI','PARIS'
//Input starting character for the string : A
//Input ending character for the string : M
//Expected Output :
//The city starting with A and ending with M is : AMSTERDAM

using System;
using System.Linq;

namespace Assignment_10._2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH",
                "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            Console.Write("Input starting character for the string: ");
            char startChar = Console.ReadKey().KeyChar;
            Console.WriteLine();

            Console.Write("Input ending character for the string: ");
            char endChar = Console.ReadKey().KeyChar;
            Console.WriteLine();

            var filteredCities = from city in cities
                                 where city.StartsWith(startChar.ToString(), 
                                                StringComparison.OrdinalIgnoreCase) &&
                                       city.EndsWith(endChar.ToString(), 
                                                StringComparison.OrdinalIgnoreCase)
                                 select city;
            if(filteredCities.Any())
            {
                Console.WriteLine($"\nThe city starting with {startChar} and ending with " 
                    + $"{endChar} is: {filteredCities.First()}");
            }
            else
            {
                Console.WriteLine($"\nNo city found starting with {startChar} and ending " + 
                    $"with {endChar}.");
            }
        }
    }
}
