namespace ChallengeLab3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("SumDigitsInString: ");
            string input = Console.ReadLine() ?? string.Empty;

            // remove the characters in the string and only accepts 0-9
            string userInput = "";
            for (int i = 0; i < input.Length; i++)
            {
                char currentCharacter = input[i];
                if (currentCharacter >= '0' && currentCharacter <= '9')
                {
                    userInput += currentCharacter;
                }
            }
            // now that the numbers is stored in userInput
            // creating an array based on how many digits is found
            int[] usersNumber = new int[userInput.Length];

            // converts the character digit into int
            for (int i = 0; i < userInput.Length; i++)
            {
                usersNumber[i] = userInput[i] - '0';
            }

            // Output the sum
            SumNumbers(usersNumber);
        }
        static void SumNumbers(int[] usersNumber)
        {
            int sum = 0;

            for (int i = 0; i < usersNumber.Length; i++)
            {
                sum += usersNumber[i];
            }
            Console.WriteLine(sum);
        }
    }
}
