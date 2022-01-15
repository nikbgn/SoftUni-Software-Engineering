﻿using System;

namespace _4._Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string currentLine = Console.ReadLine();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentLine[col];
                }
            }
            char lookingFor = char.Parse(Console.ReadLine());
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == lookingFor)
                    {
                        Console.WriteLine($"({row}, {col})");
                        Environment.Exit(0);
                    }
                }
            }

            Console.WriteLine($"{lookingFor} does not occur in the matrix");




        }
    }
}
