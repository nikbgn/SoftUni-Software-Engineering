using System;

namespace _2._Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] matrixSizes = Console.ReadLine().Split();
            int rowSize = int.Parse(matrixSizes[0]);
            int colSize = int.Parse(matrixSizes[1]);

            char[,] matrix = new char[rowSize, colSize];

            int found2x2SquaresCount = 0;

            for (int row = 0; row < rowSize; row++)
            {
                var currentLineChars = Console.ReadLine().Split();
                for (int col = 0; col < colSize; col++)
                {
                    matrix[row, col] = char.Parse(currentLineChars[col]);
                }
            }


            
            
            for (int row = 0; row < rowSize-1; row++)
            {
                for (int col = 0; col < colSize-1; col++)
                {
                    int charStart = matrix[row, col];
                    if(matrix[row,col] == charStart && matrix[row,col+1] == charStart && matrix[row+1,col] == charStart && matrix[row + 1, col + 1] == charStart)
                    {
                        found2x2SquaresCount++;
                    }
                }
            }
            Console.WriteLine(found2x2SquaresCount);
        }
    }
}
