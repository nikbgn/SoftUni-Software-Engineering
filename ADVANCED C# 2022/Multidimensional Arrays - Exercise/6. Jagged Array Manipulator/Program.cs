using System;
using System.Linq;

namespace _6._Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfRows = int.Parse(Console.ReadLine());
            double[][] jagged = new double[numOfRows][];
            for (int row = 0; row < numOfRows; row++)
            {
                int[] currentLine = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                jagged[row] = new double[currentLine.Length];
                for (int col = 0; col < currentLine.Length; col++)
                {
                    jagged[row][col] = currentLine[col];
                }
            }


            for (int row = 0; row < numOfRows - 1; row++)
            {
                int currRow = jagged[row].Length;
                int nextRow = jagged[row + 1].Length;
                //Multiply each element by 2 if currRow.Len == nextRow.Len
                if (currRow == nextRow)
                {
                    for (int i = 0; i < jagged[row].Length; i++)
                    {
                        jagged[row][i] *= 2;
                        jagged[row + 1][i] *= 2;
                    }

                }
                //Else divide each element by 2...
                else
                {
                    for (int i = 0; i < jagged[row].Length; i++)
                    {
                        jagged[row][i] /= 2;

                    }
                    for (int i = 0; i < jagged[row + 1].Length; i++)
                    {
                        jagged[row + 1][i] /= 2;

                    }

                }
            }

            while (true)
            {
                string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                switch (command[0])
                {
                    case "Add":
                        int rowAdd = int.Parse(command[1]);
                        int colAdd = int.Parse(command[2]);
                        int value = int.Parse(command[3]);
                        if (rowAdd < 0 || colAdd < 0 || rowAdd > numOfRows)
                        {
                            break;
                        }
                        else if (colAdd >= jagged[rowAdd].Length)
                        {
                            break;
                        }
                        jagged[rowAdd][colAdd] += value;
                        break;
                    case "Subtract":
                        int rowSub = int.Parse(command[1]);
                        int colSub = int.Parse(command[2]);
                        int val = int.Parse(command[3]);
                        if (rowSub < 0 || colSub < 0 || rowSub > numOfRows)
                        {
                            break;
                        }
                        else if (colSub >= jagged[rowSub].Length)
                        {
                            break;
                        }
                        jagged[rowSub][colSub] -= val;
                        break;
                    case "End":
                        for (int i = 0; i < jagged.Length; i++)
                        {
                            for (int j = 0; j < jagged[i].Length; j++)
                            {
                                Console.Write($"{jagged[i][j]} ");
                            }
                            Console.WriteLine();
                        }
                        return;
                    default:
                        break;
                }

            }



        }
    }
}
