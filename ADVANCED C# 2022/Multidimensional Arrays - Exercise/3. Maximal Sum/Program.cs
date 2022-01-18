using System;
using System.Linq;

namespace _3._Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *  4 5
                1 5 5 2 4
                2 1 4 14 3
                3 7 11 2 8
                4 8 12 16 4
             */


            int[] matrixDimensions = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int matrixRows = matrixDimensions[0];
            int matrixCols = matrixDimensions[1];
            int[,] matrix = new int[matrixRows, matrixCols];
            //Fill matrix.
            for (int row = 0; row < matrixRows; row++)
            {
                int[] currentLine = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < matrixCols; col++)
                {
                    matrix[row, col] = currentLine[col];
                }
            }

            int maxSum = int.MinValue;
            int maxRow = 0;
            int maxCol = 0;

            for (int row = 0; row < matrixRows-2; row++)
            {
                for (int col = 0; col < matrixCols-2; col++)
                {
                    int findSquareSum = squareSum(row, col, matrix);
                    if (findSquareSum > maxSum)
                    {
                        maxSum = findSquareSum;
                        maxRow = row;
                        maxCol = col;
                    }

                }
            }

            Console.WriteLine($"Sum = {maxSum}");
            for (int row = maxRow; row <= maxRow+2; row++)
            {
                for (int col = maxCol; col <= maxCol+2; col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
           



        }

        private static int squareSum(int row, int col, int[,] matrix)
        {

            int currSum = matrix[row,col] + matrix[row,col+1] + matrix[row, col + 2] + matrix[row+1, col] + matrix[row + 1, col+1] + matrix[row + 1, col + 2]+matrix[row+2,col]+matrix[row+2,col+1]+matrix[row+2,col+2];

            return currSum;
        }
    }
}
