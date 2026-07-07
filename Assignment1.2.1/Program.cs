namespace Assignment1._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Test data whether the inputted nums is equal to each other
            Console.WriteLine("Test data:");
            Console.Write("Input 1st number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input 2nd number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            // if num1 and num2 are equal, print "The numbers are equal." 
            // otherwise print "The numbers are not equal."
            if (num1 == num2)
            {
                Console.WriteLine("The numbers are equal.");
            }
            else
            {
                Console.WriteLine("The numbers are not equal.");
            }
        }
    }
}
