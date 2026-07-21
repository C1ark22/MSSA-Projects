namespace ChallengeLab3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type a word that you think is a palindrome: ");
            string input = Console.ReadLine() ?? string.Empty;

            string userInput = "";
            // assume that string only contains lowercase
            for (int i = 0; i < input.Length; i++)
            {
                char currentCharacter = input[i];
                if ( currentCharacter == 'a' && currentCharacter == 'z')
                {
                    userInput += currentCharacter;
                }
            }

            IsPalindrome(userInput);
        }
        static bool IsPalindrome(string userInput) 
        {
            int length = userInput.Length;

            for (int i = 0; i < length / 2; i++)
            {
                if (userInput[i] != userInput[length - 1 - i])
                {
                    Console.WriteLine("false");
                    return false;
                }
            }
            Console.WriteLine("true");
            return true;
        }
    }
}
