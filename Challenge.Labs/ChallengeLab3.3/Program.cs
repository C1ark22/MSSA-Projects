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
            Dictionary<int,int>numberMap = new Dictionary<int,int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int currentNumber = nums[i];

                // the number needed to reach the target
                int complementNumber = target - currentNumber;

                if (numberMap.ContainsKey(complementNumber))
                {
                    return new int[] { numberMap[complementNumber],i };
                }
                numberMap[currentNumber] = i;
            }
            return new int[] { };
        }

    }
}
