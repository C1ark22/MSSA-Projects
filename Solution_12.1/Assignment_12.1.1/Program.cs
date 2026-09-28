//Given two strings ransomNote and magazine, return true if ransomNote can be constructed
//by using the letters from magazine and false otherwise.

//Each letter in magazine can only be used once in ransomNote.

//Example 1:

//Input: ransomNote = "a", magazine = "b"

//Output: false

//Example 2:

//Input: ransomNote = "aa", magazine = "ab"

//Output: false

//Example 3:

//Input: ransomNote = "aa", magazine = "aab"

//Output: true

namespace Assignment_12._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string ransomNote = "a";
            string ransomNote = "aa";
            //string magazine = "b";
            //string magazine = "ab";
            string magazine = "aab";

            bool result = CanConstruct(ransomNote, magazine);
            Console.WriteLine(result);
        }
        public static bool CanConstruct(string ransomNote, string magazine)
        {
            // Create an array to count the occurrences of each character in the magazine
            int[] charCount = new int[26];

            // Count the occurrences of each character in the magazine
            foreach (char c in magazine)
            {
                // Increment the count for the character in the charCount array
                charCount[c - 'a']++;
            }

            // Check if each character in the ransomNote can be constructed from the magazine
            foreach (char c in ransomNote)
            {
                // If the count for the character is less than or equal to 0, return false
                if (charCount[c - 'a'] <= 0)
                {
                    return false;
                }
                // Decrement the count for the character in the charCount array
                charCount[c - 'a']--;
            }

            return true;
        }
    }
}
