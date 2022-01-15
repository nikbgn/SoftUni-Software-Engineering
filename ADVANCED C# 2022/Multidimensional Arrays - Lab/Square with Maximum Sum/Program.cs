using System;
using System.Linq;

namespace _5._Square_with_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {

            var rowsCols = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int[,] matrix = new int[rowsCols[0], rowsCols[1]];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {

                var currentRow = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < currentRow.Length; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }
            int maxSum = int.MinValue;

            int[,] square2x2 = new int[2, 2];
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int currSquareSum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if (currSquareSum > maxSum)
                    {
                        maxSum = currSquareSum;
                        square2x2[0, 0] = matrix[row, col];
                        square2x2[0, 1] = matrix[row, col + 1];
                        square2x2[1, 0] = matrix[row + 1, col];
                        square2x2[1, 1] = matrix[row + 1, col + 1];
                    }
                }
            }
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.Write(square2x2[row, col] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(maxSum);
        }
    }
}
