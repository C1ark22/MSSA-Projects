//Write a program in C# Sharp to create a list of numbers and display numbers greater than 80.
//Test Data :
//The members of the list are :
//55 200 740 76 230 482 95
//Expected Output :
//The numbers greater than 80 are :
//200
//740
//230
//482
//95

namespace Assignment_10._2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("The members of the list are : ");
            string inputNumbers = Console.ReadLine();

            List<int> numbers = inputNumbers.Split(' ')
                                          .Select(int.Parse)
                                          .ToList();
            var filteredNumbers = from number in numbers
                                  where number > 80
                                  select number;
            if(filteredNumbers.Any())
            {
                Console.WriteLine("The numbers greater than 80 are : ");
                foreach (var num in filteredNumbers)
                {
                    Console.WriteLine(num);
                }
            }
            else
            {
                Console.WriteLine("No numbers greater than 80 found.");
            };
        }
    }
}
