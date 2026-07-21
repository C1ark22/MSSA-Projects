namespace Assignment_3._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input a string: ");
            string userInput = Console.ReadLine();

            CountWhiteSpaces(userInput);
        }

        static void CountWhiteSpaces(string userInput)
        {
            int whiteSpaces = 0;

            for (int i = 0; i < userInput.Length; i++)
            {
                // as i goes up it counts the whitespaces
                if (userInput[i] == ' ')
                {
                    whiteSpaces++;
                }
            }

            Console.WriteLine($"\"{userInput}\" contains {whiteSpaces} spaces.");
        }
    }
}