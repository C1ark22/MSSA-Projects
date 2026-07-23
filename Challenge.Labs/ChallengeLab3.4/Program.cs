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
            //string originalString = "ACBBD";
            string[] subStrings = { "AB", "CD" };
            
            bool wordChange = true;
            bool removalOccured = false;
            string currentWord = originalString;

            while (wordChange) 
            {
                // Check if the current word contains any of the substrings
                string previousResult = currentWord;
                Console.WriteLine(currentWord + " (before removal)");

                // Check for each substring in the current word
                for (int i = 0; i < subStrings.Length; i++)
                {
                    currentWord = currentWord.Replace(subStrings[i], "");
                    Console.WriteLine(currentWord + "(during the removal)");
                }
                // Check if any change occurred
                wordChange = previousResult != currentWord;
                Console.WriteLine(currentWord + " (any changes occured)");

                // Check if any removal occurred
                if (wordChange)
                {
                    removalOccured = true;
                }
            }
            // Display the final result
            if (!removalOccured)
            {
                Console.WriteLine("We cannot do any operations on the " +
                        "string so the length remains the same.");
            }else
            {
                Console.WriteLine("The remaining string is: " + currentWord);
            }
        }
    }
}
