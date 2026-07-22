namespace Assignment_3._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[,] numbers = { { 2, 354, 4 },{ 1, 4, 6 } };

            int maxWidth = 0;

            foreach (int num in numbers)
            {
                int length = num.ToString().Length;
                if (length  > maxWidth) 
                    maxWidth = length;
            }
            
            for (int i = 0; i < numbers.GetLength(0); i++) 
            { 
                Console.Write("|"); 
                for (int j = 0; j < numbers.GetLength(1); j++) 
                { 
                    Console.Write($" {numbers[i,j].ToString().PadLeft(maxWidth)} |"); 
                } 
                Console.WriteLine(); 
            }

            JaggedArray();

        }
        static void JaggedArray()
        {
            int[][] numbers = { new int[]{2,3,4},
                new int[] {1,2},
                new int[] {1,4,6},
                new int[] {5} };

            // Go through each row in the jagged array
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("|");

                // Go through each number in the current row
                for (int j = 0; j < numbers[i].Length; j++)
                {
                    Console.Write($" {numbers[i][j]} |");
                }
                // Moves to the next line after finishing one row
                Console.WriteLine();
            }
        }
    }
}