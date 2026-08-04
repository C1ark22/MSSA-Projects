namespace Assignment_5._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // users give natural numbers as input
            // print out every single natural natural number
            // starting from 1 to users input
            // use recursion to print out the numbers
            Console.Write("How many numbers to print: ");
            int end = Convert.ToInt32(Console.ReadLine());
            int start = 1;
            IncreasingRecursion(start, end);
        }
        static void IncreasingRecursion(int start, int end)
        {
            if (start > end) return;
            
            Console.Write($"{start} ");
            IncreasingRecursion(start + 1, end);
        }
    }
}