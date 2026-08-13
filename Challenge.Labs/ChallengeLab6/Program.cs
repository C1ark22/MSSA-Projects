//You are given an n x n 2D matrix representing an image, 
//rotate the image by 90 degrees (clockwise).

//You have to rotate the image in-place, which means you have 
//to modify the input 2D matrix directly. DO NOT allocate 
//another 2D matrix and do the rotation.

// use i and j index

//Input: matrix = [[1, 2, 3], [4, 5, 6], [7, 8, 9]]
//Output: [[7, 4, 1],[8, 5, 2],[9, 6, 3]]

//Input: matrix = [[5, 1, 9, 11], [2, 4, 8, 10],
//                  [13, 3, 6, 7], [15, 14, 12, 16]]
//Output: [[15, 13, 2, 5],[14, 3, 4, 1],
//          [12, 6, 8, 9],[16, 7, 10, 11]]

namespace ChallengeLab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix =
                {
                    new int[] { 1, 2, 3 },
                    new int[] { 4, 5, 6 },
                    new int[] { 7, 8, 9 }
                };
            int[][] matrix2 =
            {
                new int[]{ 5, 1, 9, 11 },
                new int[]{ 2, 4, 8, 10 },
                new int[]{ 13, 3, 6, 7 },
                new int[]{ 15, 14, 12, 16 }

            };

            Rotate(matrix);

            Console.WriteLine();

            Rotate(matrix2);

        }
        public static void Rotate(int[][] matrix)
        {
            // tranpose
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = i + 1; j < matrix[i].Length; j++)
                {
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = temp;
                }
            }
            // reversing each row
            for (int i = 0; i < matrix.Length; i++)
            {
                int start = 0;
                int end = matrix.Length - 1;
                while (start < end)
                {
                    int temp = matrix[i][start];
                    matrix[i][start] = matrix[i][end];
                    matrix[i][end] = temp;

                    start++;
                    end--;
                }
            }
            // print matrix
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
