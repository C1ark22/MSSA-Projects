namespace ChallengeLab5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // I'm given an array of nums
            // some elements are may appear twice and others appear once
            // have that outputted the element that appears only once
            Dictionary<int, int> dict = new Dictionary<int, int>();

            //int[]nums = { 2, 2, 1 };
            //int[]nums = {4,1,2,1,2};
            int[]nums = {1};

            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    dict[nums[i]]++;
                }
                else
                {
                    dict.Add(nums[i], 1);
                }
            }

            foreach (KeyValuePair<int,int>pair in dict)
            {
                if (pair.Value == 1)
                {
                    Console.WriteLine(pair.Key);
                }
            }
            
        }
    }
}
