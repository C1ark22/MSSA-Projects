using System;
namespace Assignment_6._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // each element in the array multiplies to other elements
            // except itself then the output calculate the product
            // of all other elements except current element

            int[] nums = { 1, 2, 3, 4, };
            int[] nums2 = { -1, 1, 0, -3, 3 };

            int[] naiveResult = NaiveMethod(nums);
            Console.WriteLine("Naive Method");
            Console.WriteLine($"[{string.Join(", ", naiveResult)} ]");

            int[] result = ProductExceptItself(nums);
            int[] result2 = ProductExceptItself(nums2);

            Console.WriteLine("\nProduct by Itself method");
            Console.WriteLine($"[{string.Join(", ", result)} ]");
            Console.WriteLine($"[{string.Join(", ", result2)} ]");


        }
        static int[] NaiveMethod(int[] nums) 
        {
            int n = nums.Length;
            int[] result = new int[n];

            for (int i = 0; i < result.Length; i++) 
            {
                result[i] = 1;
            }


            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    // skips the first loop because they are equal to each other
                    if (i != j)
                    {
                        result[i] *= nums[j];
                    }
                }
            }
            return result;
        }

        static int[] ProductExceptItself(int[] nums)
        {
            int n = nums.Length;
            int[] before = new int[n];
            int[] after = new int[n];
            int[] result = new int[n];

            // Nothing comes before the first index
            before[0] = 1;

            // Calculate the product of everything before each index
            // Move from left to right
            for (int i = 1; i < n; i++) 
            {
                // current before product =
                // previous number * previous before product
                before[i] = nums[i - 1] * before[i - 1];
            }

            // Nothing comes after the last index
            after[n - 1] = 1;

            // Calculate the product of everything after each index
            // Move from right to left
            for (int j = n-2; j >= 0; j--)
            {
                // current after product =
                // next number * next after product
                after[j] = nums[j + 1] * after[j + 1];

            }

            // Multiply the product before and after each index
            for (int i = 0; i < n; i++)
            {
                result[i] = before[i] * after[i];
            }

            return result;
        }
    }
}
