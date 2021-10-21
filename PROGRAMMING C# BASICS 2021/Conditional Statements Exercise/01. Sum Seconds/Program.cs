using System;

namespace _01._Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstGuy = int.Parse(Console.ReadLine());
            int secondGuy = int.Parse(Console.ReadLine());
            int thirdGuy = int.Parse(Console.ReadLine());

            int timeSum = firstGuy + secondGuy + thirdGuy;

            int minutes = timeSum / 60;
            int seconds = timeSum % 60;

            if (seconds < 10)
            {
                Console.WriteLine($"{minutes}:0{seconds}");
            }
            else
            {
                Console.WriteLine($"{minutes}:{seconds}");
            }

        }
    }
}
