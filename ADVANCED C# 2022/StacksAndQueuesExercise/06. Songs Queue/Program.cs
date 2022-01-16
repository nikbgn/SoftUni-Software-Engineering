using System;
using System.Collections.Generic;

namespace _06._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> songQueue = new Queue<string>(Console.ReadLine().Split(", "));
            while (songQueue.Count > 0)
            {
                string[] command = Console.ReadLine().Split();
                switch (command[0])
                {
                    case "Play":
                        songQueue.Dequeue();
                        break;
                    case "Add":
                        string songToAdd = extractSongName(command);
                        if (songQueue.Contains(songToAdd)) Console.WriteLine($"{songToAdd} is already contained!");
                        else songQueue.Enqueue(songToAdd);
                        break;
                    case "Show":
                        Console.WriteLine(string.Join(", ",songQueue));
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine("No more songs!");
        }

        private static string extractSongName(string[] command)
        {
            string songName = string.Join(" ",command);
            return songName.Remove(0, 4);
        }
    }
}
