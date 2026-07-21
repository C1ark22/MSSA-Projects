using System.Text;

namespace Assignment_3._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // greater than 0 - 100
            int start = 0;
            int end = 100;

            // Method
            ReturnEvenNumbers(start, end);
        }
        static void ReturnEvenNumbers(int start, int end)
        {
            // Use Stringbuilder Class
            StringBuilder even = new StringBuilder();

            for (int i = start; i < end; i++)
            {
                if (i % 2 == 0)
                {
                    even.Append($"{i} ");
                }
            }

            Console.WriteLine(even.ToString());
        }
    }   
}