namespace Assignment1._3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] myName = { "C", "L", "A", "R", "K" };

            Console.Write("Printing each element in the array: ");

            foreach (string character in myName) 
            {
                Console.Write(character);
            }

            Console.WriteLine("\n");

            LengthOfArrays();

            // Cloning the original elements
            string[] sortedName = (string[])myName.Clone();
            string[] reversedName = (string[])myName.Clone();

            SortArrays(sortedName);

            ReverseArrays(reversedName);
        }

        // declaring and initializing array
        static void LengthOfArrays()
        {
            // Declaring an array and initializing a fixed size
            int[] naturalNumbers = new int[10];

            // naturalNumbers.Length tells how many elements are in the array
            for (int i = 0; i < naturalNumbers.Length; i++)
            {
                // the index starts at 0 and it increases by 1
                // the index then also moves to the next available element
                naturalNumbers[i] = i + 1;
                Console.Write(naturalNumbers[i] + " ");
            }
            Console.WriteLine("\nThe sum of the first 10 natural numbers is: " + naturalNumbers.Sum());
        }

        // Sort Array method to sortLetters from cloned myName
        static void SortArrays(string[]sortLetters) 
        {
            // Sorts the name by alphabetically
            Array.Sort(sortLetters);

            Console.Write("\nAfter Sorting the array: ");

            // the elements is updated and prints each element after update
            foreach (string sortUpdatedLetters in sortLetters)
            {
                Console.Write(sortUpdatedLetters);
            }

            Console.WriteLine(" ");
        }

        // Reverse the array to reverseLetters from cloned myName
        static void ReverseArrays(string[] reverseLetters)
        {
            // Reverses the position of each element
            Array.Reverse(reverseLetters);

            Console.Write("\nAfter Reversing the array: ");

            // the elements is updated and prints ecah element after it reverses
            foreach (string reverseUpdatedLetters in reverseLetters)
            {
                Console.Write(reverseUpdatedLetters);
            }

            Console.WriteLine(" ");
        }
    }
}
