using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> hand1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> hand2 = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (hand1.Count > 0 && hand2.Count > 0)
            {
                if (hand1[0] > hand2[0])
                {
                    hand1.Add(hand1[0]);
                    hand1.Add(hand2[0]);

                }
                else if (hand2[0] > hand1[0])
                {
                    hand2.Add(hand2[0]);
                    hand2.Add(hand1[0]);
                }
                hand1.Remove(hand1[0]);
                hand2.Remove(hand2[0]);
            }

            if (hand1.Count > hand2.Count)
            {
                Console.WriteLine($"First player wins! Sum: {hand1.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {hand2.Sum()}");
            }
        }
    }
}
