//Write a program in C# Sharp to find the positive numbers from a list of numbers using where
//conditions in LINQ Query.
//Input: { 2, -1, 3, -3, 10, -200}
//Expected output: { 2, 3, 10}

using System;
using System.Linq;

namespace Assignment_10._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, -1, 3, -3, 10, -200 };

            var positiveNumbers = from number in numbers
                                  where number > 0
                                  select number;
            //var positiveNumbers = numbers.Where(n => n > 0);

            Console.WriteLine("Positive numbers:");
            foreach (var num in positiveNumbers)
            {
                Console.Write(num + " ");
            }
        }
    }
}
