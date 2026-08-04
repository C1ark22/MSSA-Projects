namespace Assignment_5._2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // users give natural numbers as input
            // print out every single natural natural number
            // starting from the users input to 1
            // use recursion to print out the numbers
            Console.Write("How many numbers to print: ");
            int n = Convert.ToInt32(Console.ReadLine());
            DecreasingRecursion(n);
        }
        static void DecreasingRecursion(int n)
        {
            if (n == 0) return;


            Console.Write($"{n} ");
            DecreasingRecursion(n - 1);
        }
    }
}
