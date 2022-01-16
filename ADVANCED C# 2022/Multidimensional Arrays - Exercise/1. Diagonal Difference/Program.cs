using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            int[,] matrix = new int[matrixSize, matrixSize];
            //Fill in the matrix.
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var currRowNums = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currRowNums[col];
                }
            }

            int leftDiagonal = GetDiagonal(matrix, 'l');
            int rightDiagonal = GetDiagonal(matrix, 'r');
            Console.WriteLine(Math.Abs(leftDiagonal-rightDiagonal));


        }

        private static int GetDiagonal(int[,] matrix, char diagonalFlag)
        {
            int sum = 0;
            if (diagonalFlag == 'l')
            {

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    sum += matrix[i, i];
                }
            }
            else if (diagonalFlag == 'r')
            {
                int startC = matrix.GetLength(0) - 1;

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    sum += matrix[row, startC];
                    startC--;
                }
            }
            return sum;
        }
    }
}
