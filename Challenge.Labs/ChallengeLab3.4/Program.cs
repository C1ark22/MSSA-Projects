namespace ChallengeLab3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // A string contains some uppercase letters
            // A substring has 2 sets AB and CD
            // Then first remove the substring AB from the original string
            // then it shows the remaining string
            // then it will check the string if it contains the substring CD
            // then removes that substring and shows the remaining string
            // then it will check again until the string does not contain any
            // of the substrings AB or CD
            // the result will show the remaining string after all the
            // substrings have been removed

            string originalString = "ABFCACDB";
            string[] subStrings = { "AB", "CD" };
            
            //string result = originalString.Replace(substring1, "");
            //Console.WriteLine(result);

            //string result2 = result.Replace(substring2, "");
            //Console.WriteLine(result2);

            //string result3 = result2.Replace(substring1, "");
            //Console.WriteLine(result3);

            bool wordChange = true;
            string currentWord = originalString;

            while (wordChange) 
            {
                string previousResult = currentWord;
                Console.WriteLine(currentWord + " (before removal)");

                for (int i = 0; i < subStrings.Length; i++)
                {
                    currentWord = currentWord.Replace(subStrings[i], "");
                    Console.WriteLine(currentWord + "(during the removal)");
                }

                wordChange = previousResult != currentWord;
                Console.WriteLine(currentWord + " (after removal)");

            }
            Console.WriteLine($"Final result: {currentWord}");
        }
    }
}
