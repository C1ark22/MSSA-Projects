//you are given an array nums with n objects colored red, white, or blue, sort them in-place so
//that objects of the same color are adjacent, with the colors in the order red, white, and blue.

//We will use the integers 0, 1, and 2 to represent the color red, white, and blue, respectively.

//You must solve this problem without using the library's sort function.




//Example 1:

//Input: nums = [2, 0, 2, 1, 1, 0]

//Output: [0, 0, 1, 1, 2, 2]

//Explanation:

//The array has two 0s, two 1s, and two 2s. Sorting them in-place places all 0s first, then all 1s,
//then all 2s.

//Example 2:

//Input: nums = [2, 0, 1]

//Output: [0, 1, 2]

//Explanation:

//The array has one each of 0, 1, and 2, arranged in-place in the order 0, 1, 2.

 

//Constraints:

//n == nums.length
//1 <= n <= 300
//nums[i] is either 0, 1, or 2.
 

//Follow up: Could you come up with a one-pass algorithm using only constant extra space?

namespace ChallengeLab11._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 0, 2, 1, 1, 0 };
            int[] nums2 = { 2, 0, 1 };

            SortColors(nums);
            SortColors(nums2);

            Console.WriteLine(string.Join(", ", nums));
            Console.WriteLine(string.Join(", ", nums2));
        }
        // I'm given an array containing only 0s, 1s, and 2s,
        // representing red, white, and blue.
        // I need to modify the array in place so that all 0s come first,
        // followed by all 1s, then all 2s.
        //
        // A brute-force approach is bubble sort. I repeatedly compare
        // adjacent elements and swap them if they are out of order.
        // This takes O(n²) time and O(1) extra space.
        //
        // A better approach is the Dutch National Flag (DNF) algorithm.
        // It uses three pointers:
        // low: the next position where a 0 should go.
        // i: the current element being checked.
        // high: the next position where a 2 should go.
        //
        // Start low and i at 0, and high at nums.Length - 1.
        // Continue while i <= high:
        // If nums[i] is 0, swap it with nums[low], then advance low and i.
        // If nums[i] is 1, leave it in place and advance i.
        // If nums[i] is 2, swap it with nums[high], then decrease high.
        // Don't advance i after swapping a 2 because the incoming
        // element still needs to be checked.
        //
        // This sorts the array in place in O(n) time and O(1) extra space.

        //  i
        //  2   0   2   1   1   0
        //  L                   R

        //  i
        //  0   0   2   1   1   2
        //  L               R

        //  i
        //  0   0   2   1   1   2
        //  L               R

        //      i
        //  0   0   2   1   1   2
        //      L           R

        //          i
        //  0   0   2   1   1   2
        //          L       R

        //          i
        //  0   0   1   1   2   2
        //          L   R    

        //              i
        //  0   0   1   1   2   2
        //          L   R    
        // stops here because i is greater than R


        public static void SortColors(int[] nums)
        {
            int low = 0;
            int i = 0;
            int high = nums.Length - 1;

            while (i <= high)
            {
                if (nums[i] == 0)
                {
                    int temp = nums[i];
                    nums[i] = nums[low];
                    nums[low] = temp;

                    low++;
                    i++;
                }
                else if (nums[i] == 1)
                {
                    i++;
                }
                else
                {
                    int temp = nums[i];
                    nums[i] = nums[high];
                    nums[high] = temp;

                    high--;
                }
            }
        }
    }
}
