using System;
using System.Linq;

namespace FillingAJaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[][] jagged = new int[N][];
            //Filling the jagged arr with ints.
            for (int row = 0; row < jagged.Length; row++)
            {
                var currLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
                jagged[row] = new int[currLine.Length];
                for (int col = 0; col < currLine.Length; col++)
                {
                    jagged[row][col] = currLine[col];
                }
            }

            //Printing
            for (int i = 0; i < jagged.Length; i++) //jagged.Length gives us the count of arrays
            {
                for (int j = 0; j < jagged[i].Length; j++) //jagged[i].Length gives us the count of element in the jagged[i] array.
                {
                    Console.WriteLine($"jagged[{i}][{j}] = {jagged[i][j]}");
                }
            }
        }
    }
}
