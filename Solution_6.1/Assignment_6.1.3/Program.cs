namespace Assignment_6._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sliding window technique to compare current number and the next number in the array
            // if the current number is greater than the next number, move the least number to the right
            // then moved the compared number to the left
            // if the number is equal moved to the next number and compare it again
            // once the least number is at the end of the array
            // check the array again for 0
            // then do the same thing again

            int[] nums1 = { 0, 1, 0, 3, 12 };
            int[] nums2 = { 0 };
            int[] nums3 = { 0, 1, 0, 3, 12, 0, 18 };

            BubbleSort(nums1);
            BubbleSort(nums2);

            Console.WriteLine($"[ {string.Join(", ", nums1)} ]");
            Console.WriteLine($"[ {string.Join(", ", nums2)} ]");

            TwoPointerMethod(nums3);
            Console.WriteLine($"[ {string.Join(", ", nums3)} ]");
        }
        static void BubbleSort(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = 0; j < nums.Length - 1; j++)
                {
                    if (nums[j] == 0 && nums[j+1] != 0)
                    {
                        int temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
            }
        }
        static void TwoPointerMethod(int[] nums)
        {
            int numZeroes = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    var temp = nums[i - numZeroes];
                    nums[i - numZeroes] = nums[i];
                    nums[i] = temp;
                }
                else
                    numZeroes++;
            }
        }
    }
}
