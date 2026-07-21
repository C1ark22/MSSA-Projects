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

            AverageAndSumNumbers(enteredNumbers);
        }
        static void AverageAndSumNumbers(int[] numbers)
        {
            int sum = 0;
            Console.Write("The average of ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");
                sum += numbers[i];
            }

            double average = (double)sum / numbers.Length;
            Console.Write($"is {average}\n");
            Console.WriteLine($"The total is {sum}");
        }
    }
}
