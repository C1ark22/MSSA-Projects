namespace ChallengeLab2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Test Data: ");
            int temp = Convert.ToInt32(Console.ReadLine());

            if (temp <= 80 && temp >= 66)
            {
                Console.WriteLine("It's very hot.");
            } else if (temp <= 65 && temp >= 51)
            {
                Console.WriteLine("It's Hot.");
            } else if (temp <= 50 && temp >= 36)
            {
                Console.WriteLine("Normal in Weather.");
            }else if (temp <= 35 && temp >= 21)
            {
                Console.WriteLine("Cold Weather");
            }else if (temp <= 20 && temp >= 11)
            {
                Console.WriteLine("Very Cold Weather");
            }else
            {
                Console.WriteLine("Freezing Weather");
            }
        }
    }
}
