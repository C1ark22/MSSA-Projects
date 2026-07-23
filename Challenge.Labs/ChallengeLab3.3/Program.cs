namespace ChallengeLab3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {2, 7, 11, 15};
            // int[] nums = {3, 2, 4};
            // int[] nums = {3, 3};
            int target = 9;
            //int target = 6;

            int[] result = TwoSum(nums, target);
            Console.Write($"{result[0]}, {result[1]}");
        }
        static int[] TwoSum(int[] nums, int target) 
        {
            // Create a dictionary to store the numbers and their indices
            Dictionary<int,int>numberMap = new Dictionary<int,int>();

            // Iterate through the array of numbers
            for (int i = 0; i < nums.Length; i++)
            {
                // Get the current number
                int currentNumber = nums[i];

                // the number needed to reach the target
                int complementNumber = target - currentNumber;

                // Check if the complement number exists in the dictionary
                if (numberMap.ContainsKey(complementNumber))
                {
                    // If it exists, return the indices of the current number and the complement number
                    return new int[] { numberMap[complementNumber],i };
                }
                // If it doesn't exist, add the current number and its index to the dictionary
                numberMap[currentNumber] = i;
            }
            return new int[] { };
        }

    }
}
