//Given a string text, you want to use the characters of text to form as many instances of the word
//"balloon" as possible.

//You can use each character in text at most once. Return the maximum number of instances that can
//be formed.

//Example 1:

//Input: text = "nlaebolko"

//Output: 1

//Example 2:

//Input: text = "loonbalxballpoon"

//Output: 2

//Example 3:

//Input: text = "leetcode"

//Output: 0

// count the letters in the string and then divide the counts of each letter by the number of times
// that letter appears in the word "balloon". The minimum of these values will give the maximum
// number of instances of "balloon" that can be formed.

using System.ComponentModel.DataAnnotations;

namespace ChallengeLab11._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MaxNumberOfBalloons("nlaebolko");
            MaxNumberOfBalloons("loonbalxballpoon");
        }
        public static int MaxNumberOfBalloons(string text)
        {
            // Create dictionaries to count the occurrences of each character in the input text and
            // in the word "balloon".
            Dictionary<char, int> countText = new Dictionary<char, int>();
            Dictionary<char, int> balloon = new Dictionary<char, int>();

            // Count each character in text.
            foreach (char c in text)
            {
                // Increment the count for the character c in the countText dictionary.
                if (countText.ContainsKey(c))
                    countText[c]++;
                else
                    countText[c] = 1;
            }

            // Count each character needed to spell "balloon".
            foreach (char c in "balloon")
            {
                if (balloon.ContainsKey(c))
                    balloon[c]++;
                else
                    balloon[c] = 1;
            }

            int res = text.Length;

            // Iterate through each character in the balloon dictionary to determine how many times
            // we can form "balloon".
            foreach (var pair in balloon)
            {
                char c = pair.Key;
                int requiredCount = pair.Value;

                // A missing required character means we cannot form "balloon".
                if (!countText.ContainsKey(c))
                    return 0;

                res = Math.Min(res, countText[c] / requiredCount);
            }

            return res;
        }
    }

}
