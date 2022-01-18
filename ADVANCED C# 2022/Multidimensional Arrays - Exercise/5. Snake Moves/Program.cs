using System;
using System.Linq;

namespace _5._Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowsCols = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            char[,] matrix = new char[rowsCols[0], rowsCols[1]];
            string snake = Console.ReadLine();

            bool goingRight = true;
            int startIndex = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (goingRight)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[row, col] = snake[startIndex++];
                        if (startIndex == snake.Length) startIndex = 0;
                    }

                    goingRight = false;
                }
                else
                {
                    for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                    {
                        matrix[row, col] = snake[startIndex++];
                        if (startIndex == snake.Length) startIndex = 0;
                    }
                    goingRight = true;
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row,col]}");
                }
                Console.WriteLine();
            }


        }
    }
}
