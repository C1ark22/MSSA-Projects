namespace Assignment_4._3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dictionarySize;

            Console.Write("Input the number of elements to be stored in the array: ");
            // size of Dictionary is made based on users 
            while(!int.TryParse(Console.ReadLine(), out dictionarySize) || dictionarySize <= 0)
            {
                Console.WriteLine("Enter a whole number greater than 0");
            }

            Dictionary<int,int > dictionary = new Dictionary<int,int>(dictionarySize);
            // it goes through each element and adds the number what the user
            // wants in the dictionary
            for (int i = 0; i < dictionarySize; i++)
            {
                Console.Write($"element - {i} : " );
                int storedNumber = Convert.ToInt32(Console.ReadLine());
                dictionary.Add(i, storedNumber);
            }

            Console.WriteLine("Frequency of all elements of array: ");

            // creating a new dictionary where key is the number in the element 
            // and value is how many times it occurs
            Dictionary<int, int> frequency = new Dictionary<int, int>();

            foreach(int numberInElement in dictionary.Values)
            {
                if (frequency.ContainsKey(numberInElement))
                {
                    // seen before increase the value count by 1
                    frequency[numberInElement]++;
                }
                else
                {
                    // will start at 1 when seen the first time
                    frequency.Add(numberInElement, 1);
                }
            }

            // Assignment 4.3.2 frequency of a number in the dictionary
            foreach (KeyValuePair<int, int> pair in frequency) 
            {
                Console.WriteLine($"{pair.Key} occurs {pair.Value} times");
            }

            // Assignment 4.3.3 Unique element
            foreach (KeyValuePair<int, int> item in frequency)
            {
                if (item.Value == 1)
                {
                    Console.WriteLine($"The unique elements found in the array are: {item.Key} ");
                }
            }
        }
    }
}
