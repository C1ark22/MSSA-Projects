namespace Assignment_5._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] nums = {1,2,3,1};
            //int[] nums = {1,2,3,4};
            int[] nums = {1,1,1,3,3,4,3,2,4,2};

            bool containsDuplicate = ContainsDuplicate(nums);

            if(containsDuplicate)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
        static bool ContainsDuplicate(int[] arr)
        {
            Dictionary<int, int> numCounts = new Dictionary<int, int>();

            foreach (int i in arr)
            {
                if (numCounts.ContainsKey(i))
                {
                    numCounts[i]++;
                }
                else
                {
                    numCounts.Add(i, 1);
                }
            }

            Dictionary<int,int> occurrenceCounts = new Dictionary<int, int>();

            foreach (var count in numCounts.Values)
            {
                if (!occurrenceCounts.ContainsKey(count))
                {
                    return true; // Duplicate occurrence found
                }
                occurrenceCounts.Add(count, 1);
                
            }
            return false; // All occurrences are unique
        }
    }
}
