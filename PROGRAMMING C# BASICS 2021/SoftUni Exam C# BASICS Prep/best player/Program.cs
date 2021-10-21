using System;

namespace best_player
{
    class Program
    {
        static void Main(string[] args)
        {
            // USER INPUT:
            string bestPlayer = "";
            int bestScore = int.MinValue;
            string input = Console.ReadLine();
            while (input != "END")
            {
                string playerName = input;
                int score = int.Parse(Console.ReadLine());
                if (bestScore < score)
                {
                    bestScore = score;
                    bestPlayer = playerName;
                }
                if (bestScore >= 10)
                {
                    break;
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"{bestPlayer} is the best player!");
            if (bestScore >= 3)
            {
                Console.WriteLine($"He has scored {bestScore} goals and made a hat-trick !!!");
            }
            else { Console.WriteLine($"He has scored {bestScore} goals."); }
        }
    }
}
