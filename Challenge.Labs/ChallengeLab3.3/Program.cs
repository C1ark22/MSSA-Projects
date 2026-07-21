namespace ChallengeLab3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {2, 7, 11, 15};
            int target = 9;

            TwoSum(nums, target);
            Console.Write($"{TwoSum(nums, target)}");
        }
        static int[] TwoSum(int[] nums, int target) 
        {
            Dictionary<int,int>numberMap = new Dictionary<int,int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int currentNumber = nums[i];

                int complementNumber = currentNumber - target;

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
