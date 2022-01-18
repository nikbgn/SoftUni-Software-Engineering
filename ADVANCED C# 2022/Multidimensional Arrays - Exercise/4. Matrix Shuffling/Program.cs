using System;

namespace _4._Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] matrixDimensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int matrixRows = int.Parse(matrixDimensions[0]);
            int matrixCols = int.Parse(matrixDimensions[1]);
            string[,] matrix = new string[matrixRows, matrixCols];
            //Fill matrix.
            for (int row = 0; row < matrixRows; row++)
            {
                string[] currentLine = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < matrixCols; col++)
                {
                    matrix[row, col] = currentLine[col];
                }
            }

            while (true)
            {
                string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (command[0] == "END") return;
                switch (command[0])
                {
                    case "swap":
                        if (!(command.Length == 5))
                        {
                            Console.WriteLine("Invalid input!");
                            break;
                        }
                        //r1 c1 r2 c2
                        int row1 = int.Parse(command[1]);
                        int col1 = int.Parse(command[2]);
                        int row2 = int.Parse(command[3]);
                        int col2 = int.Parse(command[4]);

                        if(row1 > matrixRows || row2 > matrixRows || col1 > matrixCols || col2 > matrixCols || row1 < 0 || row2 < 0 || col1 < 0 || col2 < 0)
                        {
                            Console.WriteLine("Invalid input!");
                            break;
                        }

                        int r1c1Val = int.Parse(matrix[row1, col1]);
                        int r2c2Val = int.Parse(matrix[row2, col2]);
                        matrix[row1, col1] = r2c2Val.ToString();
                        matrix[row2, col2] = r1c1Val.ToString();
                        for (int row = 0; row < matrix.GetLength(0); row++)
                        {
                            for (int col = 0; col < matrix.GetLength(1); col++)
                            {
                                Console.Write($"{matrix[row,col]} ");
                            }
                            Console.WriteLine();
                        }


                        break;
                    default:
                        Console.WriteLine("Invalid input!");
                        break;
                }
            }
        }
    }
}
