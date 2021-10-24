using System;
using System.Collections.Generic;
using System.Linq;

namespace _03PROBLEM___Memory_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> memoryBoard = Console.ReadLine().Split().ToList();
            int moves = 0;
            while (true)
            {
                string[] command = Console.ReadLine().Split();
                moves++;
                if (command[0] == "end") break;
                int index1 = int.Parse(command[0]);
                int index2 = int.Parse(command[1]);
                bool outOfBoundry = index1 < 0 || index2 < 0 || index1 >= memoryBoard.Count || index2 >= memoryBoard.Count;
                //Check if index1 == index2 -> if so, the player is trying to cheat
                if (index1 == index2 || outOfBoundry)
                {
                    memoryBoard = addPenalty(moves, memoryBoard); //Adding the penalty.
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }

                else if (memoryBoard[index1] == memoryBoard[index2])
                {
                    string elem = memoryBoard[index1];
                    string toRemove1 = memoryBoard[index1];
                    memoryBoard.Remove(toRemove1);
                    memoryBoard.Remove(toRemove1);
                    Console.WriteLine($"Congrats! You have found matching elements - {elem}!");
                }
                else
                {
                    Console.WriteLine("Try again!");
                }

                if (memoryBoard.Count <= 1) { Console.WriteLine($"You have won in {moves} turns!"); return; }


            }

            Console.WriteLine("Sorry you lose :(");
            Console.WriteLine(string.Join(" ",memoryBoard));

        }

        private static List<string> addPenalty(int moves, List<string> memoryBoard)
        {
            memoryBoard.Insert(memoryBoard.Count / 2, $"-{moves}a");
            memoryBoard.Insert(memoryBoard.Count / 2, $"-{moves}a");
            return memoryBoard;
        }
    }
}
