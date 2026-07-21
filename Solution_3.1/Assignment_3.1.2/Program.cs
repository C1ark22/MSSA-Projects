namespace Assignment_3._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a year to check if its leap year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            CheckForLeapYear(year);
        }
        static void CheckForLeapYear(int year)
        {
            if (year % 400 == 0)
            {
                Console.WriteLine("True");
            }
            else if (year % 100 == 0)
            {
                Console.WriteLine("False");
            }
            else if (year % 4 == 0)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
