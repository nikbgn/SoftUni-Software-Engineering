using System;

namespace _06._Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int countPieces = width * length;
            // лице на тортата = брой на парчетата.
            // стоп => команда stop или ако свършат парчетата (pieces < 0).
            // продължаваме => command != "STOP"
            // команда => STOP или брой парчета

            string command = Console.ReadLine();

            while (command != "STOP")
            {
                int takenPieces = int.Parse(command);
                countPieces -= takenPieces;
                if (countPieces <= 0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(countPieces)} pieces more.");
                    break;
                }
                command = Console.ReadLine();
            }

            if (countPieces >= 0)
            {
                Console.WriteLine($"{countPieces} pieces are left.");
            }

        }
    }
}
