namespace ChallengeLab10._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 2, 3, 0, 0, 0 };
            int m = 3;

            int[] nums2 = { 2, 5, 6 };
            int n = 3;

            Merge(nums1, m, nums2, n);

            Console.WriteLine(string.Join(", ", nums1));
        }
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int i = m - 1;        // last real element in nums1
            int j = n - 1;        // last element in nums2
            int k = m + n - 1;    // last position in nums1

            while (i >= 0 && j >= 0)
            {
                if (nums1[i] > nums2[j])
                {
                    nums1[k] = nums1[i];
                    i--;
                }
                else
                {
                    nums1[k] = nums2[j];
                    j--;
                }

                k--;
            }

            // If nums2 still has elements left,
            // copy them into nums1
            while (j >= 0)
            {
                nums1[k] = nums2[j];
                j--;
                k--;
            }
        }
    }
}
