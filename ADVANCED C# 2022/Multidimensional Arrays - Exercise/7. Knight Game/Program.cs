using System;

namespace _7._Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] board = new char[size, size];

            for (int row = 0; row < board.GetLength(0); row++)
            {
                string currLine = Console.ReadLine();
                for (int col = 0; col < board.GetLength(1); col++)
                {
                    board[row, col] = currLine[col];
                }
            }
            int count = 0;
            
            while (true)
            {

                int maxAttacks = 0;
                int knightRow = 0;
                int knightCol = 0;


                for (int row = 0; row < board.GetLength(0); row++)
                {
                    for (int col = 0; col < board.GetLength(1); col++)
                    {
                        int currAttacks = 0;
                        if (board[row, col] == '0') continue;
                        //UpLeft check
                        if(IsInsideBoard(board, row-2 , col - 1) && board[row-2,col-1] == 'K')
                        {
                            currAttacks++;
                        }
                        //UpRight check
                        if (IsInsideBoard(board, row - 2, col + 1) && board[row - 2, col + 1] == 'K')
                        {
                            currAttacks++;
                        }
                        //LeftUp check
                        if (IsInsideBoard(board, row - 1 , col -2 ) && board[row - 1, col - 2] == 'K')
                        {
                            currAttacks++;
                        }
                        //LeftDown check
                        if (IsInsideBoard(board, row + 1, col - 2) && board[row + 1, col - 2] == 'K')
                        {
                            currAttacks++;
                        }
                        //DownLeft check
                        if (IsInsideBoard(board, row + 2, col - 1) && board[row + 2, col - 1] == 'K')
                        {
                            currAttacks++;
                        }
                        //DownRight check
                        if (IsInsideBoard(board, row + 2, col + 1) && board[row + 2, col + 1] == 'K')
                        {
                            currAttacks++;
                        }
                        //RightUp
                        if (IsInsideBoard(board, row + 1 , col + 2) && board[row + 1, col + 2] == 'K')
                        {
                            currAttacks++;
                        }
                        //RightDown
                        if (IsInsideBoard(board, row - 1, col + 2) && board[row - 1, col + 2] == 'K')
                        {
                            currAttacks++;
                        }

                        if(currAttacks > maxAttacks)
                        {
                            maxAttacks = currAttacks;
                            knightCol = col;
                            knightRow = row;

                            
                        }


                    }
                }

                if(maxAttacks > 0)
                {
                    board[knightRow, knightCol] = '0';
                    count++;
                }
                else
                {
                    Console.WriteLine(count);
                    return;
                }







            }


        }

        private static bool IsInsideBoard(char[,] board, int row, int col)
        {
            return row >= 0 && row < board.GetLength(0)
                && col >= 0 && col < board.GetLength(1);
        }
    }
}
