using System;

namespace Everest
{
    class Program
    {
        static void Main(string[] args)
        {
            int currMeters = 5364;
            int everest = 8848;
            int days = 1;
            int metersClimbed = 0;
            int failedReturn = 0;
            string command = Console.ReadLine();
            while (days < 5 && command != "END")
            {
                if (command == "Yes")
                {
                    metersClimbed = int.Parse(Console.ReadLine());
                    currMeters += metersClimbed;
                    failedReturn += metersClimbed;
                    days++;
                }
                else if (command == "No")
                {
                    metersClimbed = int.Parse(Console.ReadLine());
                    currMeters += metersClimbed;
                    failedReturn += metersClimbed;
                }

                if (currMeters >= everest)
                {
                    break;
                }

                command = Console.ReadLine();
            }
            if (everest - currMeters <= 0)
            {
                Console.WriteLine($"Goal reached for {days} days!");
            }
            else
            {
                Console.WriteLine($"Failed!'\r\n{5364+failedReturn}");
            }
        }
    }
}
