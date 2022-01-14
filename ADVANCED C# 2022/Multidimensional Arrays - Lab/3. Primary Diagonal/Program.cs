using System;
using System.Linq;

namespace _3._Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            int[,] matrix = new int[matrixSize, matrixSize];
            int sumDiagonalMatrix = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var currentLineNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentLineNumbers[col];
                }

            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sumDiagonalMatrix += matrix[i, i];
            }
            Console.WriteLine(sumDiagonalMatrix);
        }
    }
}
