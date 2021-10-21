using System;

namespace chetvurta
{
    class Program
    {
        static void Main(string[] args)
        {
            string teamName = Console.ReadLine();
            int matchPlayed = int.Parse(Console.ReadLine());
            int totalPoints = 0;
            int winsCount = 0;
            int drawCounts = 0;
            int lostCount = 0;

            for (int i = 0; i < matchPlayed; i++)
            {
                char result = char.Parse(Console.ReadLine());

                if (result == 'W')
                {
                    totalPoints += 3;
                    winsCount++;
                }
                else if (result == 'D')
                {
                    totalPoints++;
                    drawCounts++;
                }
                else if(result == 'L')
                {
                    lostCount++;
                }
            }
            if (matchPlayed == 0)
            {
                Console.WriteLine($"{teamName} hasn't played any games during this season.");
            }
            else
            {
                double winrate = winsCount * 1.0 / matchPlayed * 100;
                Console.WriteLine($"{teamName} has won {totalPoints} points during this season.\r\nTotal stats:\r\n## W: {winsCount}\r\n## D: {drawCounts}\r\n## L: {lostCount}\r\nWin rate: {winrate:f2}%");
            }
        }
    }
}
