namespace Assignment2._4._1
{
    public class ArrayDetails()
    {
        public int[] Numbers { get; set; } = Array.Empty<int>();

        public void GetUserInput()
        {
            Console.Write("Input the number of elements to be stored in the array: ");
            int numberOfElements = Convert.ToInt32(Console.ReadLine());

            int[] Numbers = new int[numberOfElements];

            for (int i = 0; i < Numbers.Length; i++)
            {
                Console.Write($"\nelement - {i} :");
                Numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"\nSum of all elements stored in the array is : " +
                $"{Numbers.Sum()}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayDetails arrayDetails = new ArrayDetails();

            arrayDetails.GetUserInput();
        }
    }
}
