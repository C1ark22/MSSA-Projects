namespace ChallengeLab10._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "abcd";
            string t = "abcde";

            char result = FindTheDifference(s, t);

            Console.WriteLine($"The added letter is: {result}");
        }
        public static char FindTheDifference(string s, string t)
        {
            Dictionary<char, int> countS = new Dictionary<char, int>();
            Dictionary<char, int> countT = new Dictionary<char, int>();

            foreach (char letter in s)
            {
                if (countS.ContainsKey(letter))
                {
                    countS[letter]++;
                }
                else
                {
                    countS.Add(letter, 1);
                }
            }
            foreach (char letter in t)
            {
                if (countT.ContainsKey(letter))
                {
                    countT[letter]++;
                }
                else
                {
                    countT.Add(letter, 1);
                }
            }
            foreach (var pair in countT)
            {
                char letter = pair.Key;

                if (!countS.ContainsKey(letter) || countT[letter] > countS[letter])
                {
                    return letter;
                }

            }
            return '\0';
        }
    }
}
