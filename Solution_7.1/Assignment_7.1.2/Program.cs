// You are given two strings word1 and word2. Merge the
// strings by adding letters in alternating order, starting
// with word1. If a string is longer than the other, append
// the additional letters onto the end of the merged string.
// Return the merged string.


namespace Assignment_7._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word1 = "abc";
            //string word2 = "pqr";
            string word2 = "pqrs";
            //string word2 = "pq";

            // we know that the first letter in the first word would start
            // then the second word would go in between
            // it doesn't matter whether the first word is shorter
            // it would still prioritize the first word
            // then if any of the word still has a letter add it

            Console.WriteLine($"{MergeAlternately(word1, word2)}");
        }

        static string MergeAlternately(string word1, string word2)
        {
            string result = "";

            int i = 0;
            while (i < word1.Length || i < word2.Length )
            {
                if ( i < word1.Length)
                {
                    result += word1[i];
                }
                if (i < word2.Length)
                {
                    result += word2[i];
                }
               
                i++;
            }

            return result;
        }
    }
}
