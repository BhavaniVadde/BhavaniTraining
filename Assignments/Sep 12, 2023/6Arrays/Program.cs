namespace _6Arrays
{
    public class Program
    {
        static void Main()
        {

            Console.Write("Input the rows and columns of first matrix : ");
            string[] size1 = Console.ReadLine().Split();
             int rows1 = Convert.ToInt32(size1[0]);
            int cols1 = Convert.ToInt32(size1[1]);

            Console.Write("Input the rows and columns of second matrix : ");
            string[] size2 = Console.ReadLine().Split();
            int rows2 = Convert.ToInt32(size2[0]);
            int cols2 = Convert.ToInt32(size2[1]);

            if (cols1 != rows2)
            {
                Console.WriteLine("Matrix multiplication is not possible.");
                return;
            }

            int[,] matrix1 = new int[rows1, cols1];
            int[,] matrix2 = new int[rows2, cols2];

            Console.WriteLine("Input elements in the first matrix:");
            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols1; j++)
                {
                    Console.Write($"element - [{i}],[{j}] : ");
                    matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Input elements in the second matrix:");
            for (int i = 0; i < rows2; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    Console.Write($"element - [{i}],[{j}] : ");
                    matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            // Perform matrix multiplication and store the result in a new matrix
            int[,] resultMatrix = MultiplyMatrices(matrix1, matrix2, rows1, cols1, cols2);

            Console.WriteLine("The First matrix is:");
            PrintMatrix(matrix1);

            Console.WriteLine("The Second matrix is:");
            PrintMatrix(matrix2);

            Console.WriteLine("The multiplication of two matrices is:");
            PrintMatrix(resultMatrix);
        }
        // Function to multiply two matrices
        static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2, int rows1, int cols1, int cols2)
        {
            int[,] resultMatrix = new int[rows1, cols2];

            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < cols1; k++)
                    {
                        sum += matrix1[i, k] * matrix2[k, j];
                    }
                    resultMatrix[i, j] = sum;
                }
            }

            return resultMatrix;
        }
        // Function to print a matrix
        static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}