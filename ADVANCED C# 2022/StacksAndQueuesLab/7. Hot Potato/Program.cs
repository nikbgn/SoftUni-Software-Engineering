using System;
using System.Collections.Generic;

namespace _7._Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> kidsPlaying = new Queue<string>(Console.ReadLine().Split());
            int kidLosesAtNThrows = int.Parse(Console.ReadLine());
            int throwCount = 0;
            while (kidsPlaying.Count > 1)
            {
                throwCount++;
                string currentKid = kidsPlaying.Dequeue();
                if (throwCount == kidLosesAtNThrows)
                {
                    Console.WriteLine($"Removed {currentKid}");
                    throwCount = 0;
                }
                else kidsPlaying.Enqueue(currentKid);
            }

            Console.WriteLine($"Last is {kidsPlaying.Dequeue()}");
        }
    }
}
