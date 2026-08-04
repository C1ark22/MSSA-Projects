namespace Assignment_5._1.fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IterativeApproach();
            RecursiveApproach();
        }
        static void IterativeApproach()
        {
            int firstNum = 0, secondNum = 1, nextNum, numOfElements;

            Console.WriteLine("Enter the number of elements for the Fibonacci sequence:");
            numOfElements = Convert.ToInt32(Console.ReadLine());

            if (numOfElements < 2)
            {
                Console.WriteLine("Please enter a number greater than or equal to 2.");
            }
            else
            {
                Console.Write($"{firstNum} {secondNum} ");
                for (int i = 2; i < numOfElements; i++)
                {
                    nextNum = firstNum + secondNum;
                    Console.Write($"{nextNum} ");
                    firstNum = secondNum;
                    secondNum = nextNum;
                }
            }
        }
        static void RecursiveApproach() 
        {
            int n = 8;
            Console.WriteLine("\nFibonacci series using recursive approach");

            for (int i = 0; i < n; i++) 
            {
                Console.Write($"{Fibonacci(i)} ");
            }
        }

        static int Fibonacci(int num)
        {
            if (num <= 1)
                return num;
            else
                return Fibonacci(num - 1) + Fibonacci(num - 2);
        }
    }
}
