namespace Assignment1._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // stores the natural numbers in an array and prints the sum to the console
            Console.WriteLine("The first 10 natural numbers are:");
            int[] naturalNumbers = new int[10];

            for (int i = 0; i < naturalNumbers.Length; i++)
            {
                naturalNumbers[i] = i + 1;
                Console.Write(naturalNumbers[i] + " ");
            }
            Console.WriteLine("\nThe sum of the first 10 natural numbers is: " + naturalNumbers.Sum());
        }
    }
}
