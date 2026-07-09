namespace Assignment1._3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the number of elements to store in the array: ");

            // the user inputs the number of elements to store in the array
            int arraySize = Convert.ToInt32(Console.ReadLine());

            // the int of arraySize is then converted to the size of array
            int[] numbers = new int[arraySize];

            // the loop lets the user saves the number starting at 0 and goes up by 1
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"\nelement - {i} : ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nThe values store in the array are: ");
            
            // the values that was stored is then printed
            foreach(int values in numbers)
            {
                Console.Write(values + " ");
            }

            // left points to the beginning of the array
            int left = 0;
            // right is the last element of the array
            int right = numbers.Length - 1;

            while (left < right)
            {
                // Save the value from the left side before it gets overwritten
                int temp = numbers[left];

                // Moves the value from the right into the left side of the array
                numbers[left] = numbers[right];

                // Moves the saved origal value into the right side of the array
                numbers[right] = temp;

                // moves left pointer one step forward
                left++;

                // moves right pointer one step backward
                right--;
            }

            Console.WriteLine("\nThe values store in the array in reverse are: ");

            // the newly updated reversed numbers is then printed
            foreach (int reverseValues in numbers)
            {
                Console.Write(reverseValues + " ");
            }
        }
    }
}
