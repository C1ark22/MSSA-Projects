namespace Assignment_3._1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("For eg: Input: ");
            string userInput = Console.ReadLine();

            // trim the brackets
            userInput = userInput.Trim('[', ']');

            // splits the user input
            string[] inputParts = userInput.Split(',');

            // creating an array
            int[] usersInput = new int[inputParts.Length];

            // assigns it to an element
            for (int i = 0; i < inputParts.Length; i++)
            {
                usersInput[i] = Convert.ToInt32(inputParts[i].Trim());
            }

            RepeatedNumbers(usersInput);

            Console.WriteLine($"[{string.Join(",", usersInput)}]");
        }
        static void RepeatedNumbers(int[] usersInput)
        {
            // checks the array for the first 2 consecutive 1's
            for (int i = 0; i < usersInput.Length - 1; i++)
            {
                if (usersInput[i] == 1 && usersInput[i + 1] == 1)
                {
                    usersInput[i] = 0;
                    usersInput[i + 1] = 0;

                    break;
                }
            }
        }
    }
}