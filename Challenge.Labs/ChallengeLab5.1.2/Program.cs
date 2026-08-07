namespace ChallengeLab5._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // we are given an array of nums
            // n distict numbers in the array in the range [0, n]
            // we are to return the only number that is missing from the array
            // then output that number is the missing number
            // how do you add a number to an array that is not there
            // should we order the number to see what is missing or
            // should we use a dictionary to see what is missing
            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            int[] nums = { 3, 0, 1 };
            int[] nums2 = { 0, 1 };
            int[] nums3 = { 9, 6, 4, 2, 3, 5, 7, 0, 1 };
 
            Console.WriteLine(MissingNumber(nums));
            Console.WriteLine(MissingNumber(nums2));
            Console.WriteLine(MissingNumber(nums3));

            // use a dictionary to see what is missing
            // then use a loop to see what is missing
            // then output that number is the missing number
            // use minimmum and maximum to find the range of numbers
            // the loop ends at the maximum number in the array
            // if not in the dictionary then that is the missing number

        }
        static int MissingNumber(int[] nums)
        {
            int n = nums.Length + 1;
            // loop through the array and check if the number is in the array
            for (int i = 0; i < nums.Length; i++)
            {
                // check if the number is in the array
                bool found = false;
                // loop through the array and check if the number is in the array
                for (int j = 0; j < nums.Length; j++)
                {
                    // if the number is in the array then set found to true
                    if (nums[j] == i)
                    {
                        found = true;
                        break;
                    }
                }
                // if the number is not in the array then return that number
                if (!found)
                    return i;

            }
            
            return n - 1;
        }
    }
}
