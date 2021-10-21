using System;

namespace _04._Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int stepsTaken = 0;
            string command = "";


            while (stepsTaken <= 10000)
            {
                command = Console.ReadLine();
                if (command == "Going home") { stepsTaken += int.Parse(Console.ReadLine()); break; }
                stepsTaken += int.Parse(command);

            }

            if (stepsTaken < 10000) { Console.WriteLine($"{10000-stepsTaken} more steps to reach goal."); }
            else if (stepsTaken >= 10000) { Console.WriteLine($"Goal reached! Good job!\n{stepsTaken-10000} steps over the goal!"); }

            
        }
    }
}
