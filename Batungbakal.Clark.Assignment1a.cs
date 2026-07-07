using System;

namespace Batungbakal.Clark.Assignment1a
{
    class Program
    {
        static void Main(string[] args)
        {
            // This portion of the code prints out my name, age and address to the console
            const string name = "Clark Batungbakal";
            uint age = 29;
            string address = "2316 Edmund Ct, Fairfield, CA 94533, USA";

            Console.WriteLine("My name is " + name + ", I am " + age + 
            " years old, and I live at " + address + ".\n");

            // This portion of the code gets the user's input and prints out the sum to the console
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double sum = num1 + num2;
            Console.WriteLine("The sum of " + num1 + " and " + num2 + " is " + sum + ".\n");

            // This portion of the code gets the user's input and prints out the
            // quotient and remainder to the console
            Console.Write("Enter the dividend: ");
            Decimal dividend = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter the divisor: ");
            Decimal divisor = Convert.ToDecimal(Console.ReadLine());

            Decimal quotient = (Decimal)dividend / divisor;
            Decimal remainder = dividend % divisor;
            Console.WriteLine("The quotient of " + dividend + " divided by " + divisor + " is " 
            + quotient + " with a remainder of " + remainder + ".\n");
        }
    }
}