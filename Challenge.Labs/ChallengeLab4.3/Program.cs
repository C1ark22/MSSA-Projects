namespace ChallengeLab4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReverseForLoop();
            ReverseWhileLoop();
        }
        static void ReverseForLoop()
        {
            char[] s = { 'h', 'e', 'l', 'l', 'o' };
            // char[] s = { 'H', 'a', 'n', 'n', 'a', 'h' };

            for (int i = 0; i < s.Length / 2; i++)
            {
                char temp = s[i];
                s[i] = s[s.Length - 1 - i];
                s[s.Length - i - 1] = temp;
            }
            Console.WriteLine(s);
        }
        static void ReverseWhileLoop()
        {
            // char[] s = { 'h', 'e', 'l', 'l', 'o' };
            char[] s = { 'H', 'a', 'n', 'n', 'a', 'h' };

            int start = 0;
            int end = s.Length - 1;

            while (start <= end)
            {
                char temp = s[start];
                s[start] = s[end];
                s[end] = temp;

                start++;
                end--;
            }
            Console.WriteLine(s);
        }
    }
}
