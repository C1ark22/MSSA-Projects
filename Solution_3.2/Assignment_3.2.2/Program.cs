namespace Assignment_3._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // user input size of the Matrices
            Console.Write("Input the size of the square matrix (less than 5): ");
            int inputtedSize = Convert.ToInt32(Console.ReadLine());

            // create the size of the square matrix based on the users input
            int[,] firstMatrix = new int [inputtedSize, inputtedSize];
            int[,] secondMatrix = new int[inputtedSize, inputtedSize];

            InputtedElements(firstMatrix, secondMatrix, inputtedSize);

            // output 
            // prints the size of the matrices
            // prints the addition of both matrices

            Console.WriteLine("\nThe First Matrix is:");
            MatrixDisplay(firstMatrix);

            Console.WriteLine("\nThe First Matrix is:");
            MatrixDisplay(secondMatrix);

            SumOfMatrices(firstMatrix,secondMatrix);
            
        }

        static void InputtedElements(int[,] firstMatrix, int[,] secondMatrix, int inputtedSize)
        {
            Console.WriteLine("Input elements in the First Matrix:");
            // user input for each elements { {#,#},{#,#} } on the first matrix
            for (int i = 0; i < inputtedSize; i++)
            {
                for (int j = 0; j < inputtedSize; j++)
                {
                    Console.Write($"element - [{i}],[{j}]: ");
                    firstMatrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Input elements in the Second Matrix:");
            // user input for each elements { {#,#},{#,#} } in the second matrix
            for (int i = 0; i < inputtedSize; i++)
            {
                // do the same for the second matrice
                for (int j = 0; j < inputtedSize; j++)
                {

                    Console.Write($"element - [{i}],[{j}]: ");
                    secondMatrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        static void MatrixDisplay(int[,] matrixes)
        {
            // number of rows
            for (int i = 0; i < matrixes.GetLength(0); i++)
            {
                //number of columns
                for(int j = 0;j < matrixes.GetLength(1); j++)
                {
                    Console.Write(matrixes[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void SumOfMatrices(int[,] firstMatrix, int[,] secondMatrix)
        {
            int[,] sum = new int
                [ firstMatrix.GetLength(0), firstMatrix.GetLength(1)];

            // for i element firstMatrix [i,0] add secondMatrix[i,0]
            // for j element firstMatrix [0,j] add secondMatrix[0,j]
            for (int i = 0; i < firstMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < firstMatrix.GetLength(1); j++)
                {
                    sum[i, j] = firstMatrix[i, j] + secondMatrix[i, j];
                }
            }
            Console.WriteLine("\nThe addition of two matrix is:");

            for (int i = 0; i < sum.GetLength(0); i++)
            {
                for (int j = 0; j < sum.GetLength(1); j++)
                {
                    Console.Write(sum[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
