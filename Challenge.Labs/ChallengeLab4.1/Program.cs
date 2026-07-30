namespace ChallengeLab4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ContainsDigit(7201432));
            Console.WriteLine(ContainsDigit(87501));

        }
        static bool ContainsDigit(int digit)
        {
            while (digit > 0)
            {
                int lastDigit = digit % 10;

                if (lastDigit == 3)
                {
                    return true;
                }
                digit /= 10;
            }
            return false;
        }
    }
}
