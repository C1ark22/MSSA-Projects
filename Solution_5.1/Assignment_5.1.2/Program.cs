namespace Assignment_5._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            string numberInput = Console.ReadLine() ?? string.Empty;

            Dictionary<int,int> digits = new Dictionary<int,int>();

            int sum = 0;
            for (int i = 0; i < numberInput.Length; i++)
            {
                int digit = numberInput[i] - '0'; // Convert char to int
                digits.Add(i, digit);
                sum += digit;
            }
            Console.WriteLine($"Sum of digits: {sum}");
        }
    }
}
