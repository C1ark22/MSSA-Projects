namespace Assignment_5._3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //staircase problem
            //int n = 1;
            //int n = 2;
            //int n = 3;
            //int n = 4;
            int n = 5;

            int numberOfWays = FibonacciRecursion(n);
            Console.WriteLine(numberOfWays);
        }
        static int FibonacciRecursion(int n)
        {
            if (n==1)
                return 1; 

            if (n==2) 
                return 2;

            return FibonacciRecursion(n-1) + FibonacciRecursion(n - 2);
        }
    }
}
