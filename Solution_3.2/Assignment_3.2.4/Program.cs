using System.Diagnostics.CodeAnalysis;

namespace Assignment_3._2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] enteredNumbers = new int [4];

            Console.Write("Enter the First number: ");
            enteredNumbers[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Second number: ");
            enteredNumbers[1] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Third number: ");
            enteredNumbers[2] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Fourth number: ");
            enteredNumbers[3] = Convert.ToInt32(Console.ReadLine());

            AverageAndSumNumbers(out int total, out double average, enteredNumbers);

            Console.Write("The average of ");
            for (int i = 0; i < enteredNumbers.Length; i++)
            {
                Console.Write($"{enteredNumbers[i]} ");
            }

            Console.WriteLine($"is {average}");
            Console.WriteLine($"The total is {total}");
        }
        // (returns total, returns average, accepts multiple integers)
        static void AverageAndSumNumbers(out int total, out double average, params int[]numbers )
        {
            total = 0;
            
            for (int i = 0; i < numbers.Length; i++)
            {
                total += numbers[i];
            }

            average = (double)total / numbers.Length;
            
        }
    }
}
