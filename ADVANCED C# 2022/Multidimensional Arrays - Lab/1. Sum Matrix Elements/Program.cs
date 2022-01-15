using System;
using System.Linq;

namespace _1._Sum_Matrix_Elements
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
            int sum = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    sum += matrix[row, col];
                }
                
            }
            Console.WriteLine(rowsCols[0]);
            Console.WriteLine(rowsCols[1]);
            Console.WriteLine(sum);
        }
    }
}
