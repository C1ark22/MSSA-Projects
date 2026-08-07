namespace Assignment_5._4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for a number and print it to the console
            // the number should be stored in a variable called userInput
            // since its a string, we will need to seperate to each int
            // then give that result in the console using recursion

            Console.Write("Input any number: ");
            string userInput = Console.ReadLine();

            NumberRecursion(userInput);
        }

        static void NumberRecursion(string number)
        {
            if (string.IsNullOrEmpty(number))
                return;

            int digit = int.Parse(number[0].ToString());
            Console.Write(digit + " ");

            NumberRecursion(number.Substring(1));
        }
    }
}
