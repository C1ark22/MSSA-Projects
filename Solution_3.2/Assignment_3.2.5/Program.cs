namespace Assignment_3._2._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = { 1, 5, 3 };
            int firstTarget = 5;
            int[] secondArray = { 9, 8, 3 };
            int secondTarget = 3;
            int[] thirdArray = { 1, 2, 3 };
            int thirdTarget = 4;

            int firstResult = LinearSearch(firstArray, firstTarget);
            int secondResult = LinearSearch(secondArray, secondTarget);
            int thirdResult = LinearSearch(thirdArray, thirdTarget);

            Console.WriteLine(firstResult);
            Console.WriteLine(secondResult);
            Console.WriteLine(thirdResult);

        }
        static int LinearSearch(int[] array, int target)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                    // target found
                    return i;
            }
            return -1;
        }
    }
}
