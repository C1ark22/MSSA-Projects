namespace Assignment_5._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a number: ");
            int  x = Convert.ToInt32(Console.ReadLine());
            bool isBoolean = IsBoolean(x);

            if (isBoolean)
            {
                Console.WriteLine($"{x} is a palindrome.");
            }
            else
            {
                Console.WriteLine($"{x} is not a palindrome.");
            }
        }
        static bool IsBoolean(int x)
        {
            var xString = x.ToString();

            for(int i = 0; i < xString.Length/2; i++) {

                // Compare characters from the start and end of the string
                if (xString[i] != xString[xString.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
