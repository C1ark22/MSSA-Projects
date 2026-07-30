namespace ChallengeLab4._2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(DivisibleBy2Or3(15, 30)); // 450
            Console.WriteLine(DivisibleBy2Or3(2, 90));  // 180
            Console.WriteLine(DivisibleBy2Or3(7, 12));  // 19
        }

        static int DivisibleBy2Or3(int number1, int number2)
        {
            bool number1IsDivisible =
                number1 % 2 == 0 || number1 % 3 == 0;

            bool number2IsDivisible =
                number2 % 2 == 0 || number2 % 3 == 0;

            if (number1IsDivisible && number2IsDivisible)
            {
                return number1 * number2;
            }
            else
            {
                return number1 + number2;
            }
        }
    }
}
