using System;

namespace _07StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            int power = 0;

            for (int i = 0; i < line.Length; i++)
            {
                char symbol = line[i];

                if (symbol == '>')
                {
                    power += int.Parse(line[i + 1].ToString());
                    continue;
                }

                if (power > 0)
                {
                    line = line.Remove(i, 1);
                    power--;
                    i--;
                }
            }

            Console.WriteLine(line);
        }
    }
}