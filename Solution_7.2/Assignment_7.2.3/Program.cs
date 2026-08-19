//Given two strings s and t, return true if t is an anagram
//of s, and false otherwise. An Anagram is a word or phrase
//formed by rearranging the letters of a different word or
//phrase, typically using all the original letters
//exactly once.

//Example 1:

//Input: s = "anagram", t = "nagaram"

//Output: true

//Example 2:

//Input: s = "rat", t = "car"

//Output: false

namespace Assignment_7._2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string s = "anagram";
            //string t = "nagaram";
            string s = "rat";
            string t = "car";
            bool similar = IsAnagram(s, t);
            Console.WriteLine(similar);
        }
        public static bool IsAnagram(string s, string t)
        {
            // compares both strings whether they contain the same
            // characters in the string, by sorting them alpabetically
            // if not equal return false, if equal return true
            char[] sSort = s.ToCharArray();
            char[] tSort = t.ToCharArray();

            if (s.Length != t.Length)
            {
                return false;
            }
            
            // sort alphabetically for the first word
            for (int i = 0; i < sSort.Length - 1; i++)
            {
                int smallestIndex = i;

                for (int j = i + 1; j < sSort.Length; j++)
                {
                    if (sSort[j] < sSort[smallestIndex])
                    {
                        smallestIndex = j;
                    }
                }

                // swap
                char temp = sSort[i];
                sSort[i] = sSort[smallestIndex];
                sSort[smallestIndex] = temp;
            }

            Console.WriteLine("Sorted first string: " + new string(sSort));

            // sort alphabetically for the second word
            for (int i = 0; i < tSort.Length - 1; i++)
            {
                int smallestIndex = i;

                for (int j = i + 1; j < tSort.Length; j++)
                {
                    if (tSort[j] < tSort[smallestIndex])
                    {
                        smallestIndex = j;
                    }
                }

                // swap
                char temp = tSort[i];
                tSort[i] = tSort[smallestIndex];
                tSort[smallestIndex] = temp;
            }

            Console.WriteLine("Sorted second string: " + new string(tSort));

            bool same = true;

            for (int i = 0; i < sSort.Length; i++)
            {
                if (sSort[i] != tSort[i])
                {
                    same = false;
                    break;
                }
            }

            return same;
        }
    }
}
