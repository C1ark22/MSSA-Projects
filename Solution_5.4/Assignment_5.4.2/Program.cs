using System.ComponentModel;

namespace Assignment_5._4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // user inputs the size of the square matrix
            // then the user inputs the values of the matrix
            // using 2d arrays, we will store the values in a jagged array
            // then value 0,1 and value 1,0 will print the sum of the
            // right diagonal values of the matrix

            Console.Write("Input the size of the square matrix: ");
            int inputtedSize = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[inputtedSize, inputtedSize];

            InputtedElements(matrix, inputtedSize);

        }

        static void InputtedElements(int[,] matrix, int size)
        { 
            int sum = 0;
            Console.WriteLine("Input the elements of the matrix:");

            for (int i = 0; i < size; i++) 
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write($"Element [{i},{j}]: ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());

                    // check if the current element is on the right diagonal
                    if (i + j == size - 1)
                    {
                        sum += matrix[i, j];
                    }
                }
            }
            Console.WriteLine($"The sum of the right diagonal elements is: {sum}");
        }
    }
}
