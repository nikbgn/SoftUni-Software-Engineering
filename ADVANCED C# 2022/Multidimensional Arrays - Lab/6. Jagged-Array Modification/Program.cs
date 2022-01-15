using System;

namespace _6._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int[rows][];
            for (int row = 0; row < rows; row++)
            {
                var currentLineNumbers = Console.ReadLine().Split();
                jaggedArray[row] = new int[currentLineNumbers.Length];
                int cols = currentLineNumbers.Length;
                for (int col = 0; col < cols; col++)
                {
                    jaggedArray[row][col] = int.Parse(currentLineNumbers[col]);
                }
            }

            while (true)
            {
                string[] command = Console.ReadLine().Split();
                string currentCommand = command[0];
                if(currentCommand == "END")
                {
                    PrintJaggedArray(jaggedArray);
                    break;
                }
                int commandRow = int.Parse(command[1]);
                int commandCol = int.Parse(command[2]);
                int commandValue = int.Parse(command[3]);

                
                if(commandRow < 0 || commandCol < 0 || commandRow > rows)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }
                else
                {
                    if(jaggedArray[commandRow].Length-1 < commandCol)
                    {
                        Console.WriteLine("Invalid coordinates");
                        continue;
                    }
                }

                switch (currentCommand)
                {
                    case "Add":
                        jaggedArray[commandRow][commandCol] += commandValue;
                        break;
                    case "Subtract":
                        jaggedArray[commandRow][commandCol] -= commandValue;
                        break;
                    default:
                        break;
                }

            }

        }

        private static void PrintJaggedArray(int[][] jaggedArray)
        {
            for (int row = 0; row < jaggedArray.Length; row++)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    Console.Write(jaggedArray[row][col] + " ");
                }
                Console.WriteLine();
            }
            
        }
    }
}
