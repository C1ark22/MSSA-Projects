// Implement merge sort on an unsorted array
// of numbers. Take the array input from user.

namespace Assignment_7._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a set of numbers to be sorted: ");
            string userInput = Console.ReadLine();

            string[] numberStrings = userInput.Split(' ');

            int[] numbers = new int[numberStrings.Length];

            for (int i = 0; i < numberStrings.Length; i++)
            {
                numbers[i] = Convert.ToInt32(numberStrings[i]);
            }

            int left = 0;
            int right = numbers.Length - 1;

            MergeSort(numbers, left, right);

            Console.WriteLine("Sorted array:");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
        static void MergeSort(int[] numbers, int left, int right)
        {
            // stop when one element remains
            if (left >= right)
            {
                return;
            }

            int middle = (left + right) / 2;

            // split left section
            MergeSort(numbers, left, middle);

            // split right section
            MergeSort(numbers, middle + 1, right);

            // combine the two sorted sides
            Merge(numbers, left, middle, right);

        }
        static void Merge(int[] numbers, int left, int middle, int right)
        {
            int leftPointer = left;
            int rightPointer = middle + 1;

            int[] temp = new int[right - left +1];

            int tempIndex = 0;

            // compare left and right sides
            while (leftPointer <= middle && rightPointer <= right)
            {
                // left number is smaller than right number
                if (numbers[leftPointer] < numbers[rightPointer])
                {
                    // add left number to the temporary storage
                    temp[tempIndex] = numbers[leftPointer];

                    leftPointer++;
                    tempIndex++;
                }
                else 
                {
                    // add right number to the temporary storage
                    temp[tempIndex] = numbers[rightPointer];

                    rightPointer++;
                    tempIndex++;
                }
            }
            // copy remaining left sides
            while (leftPointer <= middle)
            {
                temp[tempIndex] = numbers[leftPointer];

                leftPointer++;
                tempIndex++;

            }

            // copy remaining right side
            while (rightPointer <= right)
            {
                temp[tempIndex] = numbers[rightPointer];

                rightPointer++;
                tempIndex++;
            }
            
            // copy temp back into original array
            for(int i = 0; i < temp.Length; i++) 
            {
                numbers[left + i] = temp[i];
            }
        }
    }
}
