using System;
using System.Linq;

namespace _2._Sum_Matrix_Columns
{
    class Program
    {
        static void Main(string[] args)
        {
            

            var rowColInfo = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int[rowColInfo[0], rowColInfo[1]];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var currentNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentNumbers[col];
                }
            }

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int currentSum = 0;
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    currentSum += matrix[row, col];
                }
                Console.WriteLine(currentSum);
            }


        }
    }
}
