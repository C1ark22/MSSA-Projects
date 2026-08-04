namespace Assignment_5._2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The users input a string and we must figure out
            // that the string is a palindrome or not using recursion

            Console.Write("Input a string: ");
            string s = Console.ReadLine();
            int left = 0;
            int right = s.Length - 1;

            PalindromeRecursion(s, left, right);
        }
        static bool PalindromeRecursion(string s, int left, int right)
        {
            if (left>= right)
            {
                Console.WriteLine($"The string {s} is a palindrome");
                return true;
            }
            if (s[left] != s[right])
            {
                Console.WriteLine($"The string {s} is not a palindrome");
                return false;
            }
            return PalindromeRecursion(s, left + 1, right - 1);
        }
    }
}
