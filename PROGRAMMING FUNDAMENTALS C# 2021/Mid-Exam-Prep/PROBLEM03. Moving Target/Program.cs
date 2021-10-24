using System;
using System.Collections.Generic;
using System.Linq;

namespace PROBLEM03._Moving_Target
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] command = Console.ReadLine().Split();

            while (true)
            {
                switch (command[0])
                {
                    case "Shoot":
                        int index = int.Parse(command[1]);
                        int power = int.Parse(command[2]);
                        if (index >= 0 && index < targets.Count)
                        {
                            targets[index] -= power;
                            if (targets[index] <= 0) { targets.RemoveAt(index); }
                        }
                        break;
                    case "Add":
                        int place = int.Parse(command[1]);
                        int value = int.Parse(command[2]);
                        if (place >= 0 && place < targets.Count)
                        {
                            targets.Insert(place, value);
                        }
                        else
                        {
                            Console.WriteLine("Invalid placement!");
                        }
                        break;
                    case "Strike":
                        int targetToRemove = int.Parse(command[1]);
                        int radius = int.Parse(command[2]);
                        bool leftPossible = true ? targetToRemove - radius >= 0 : false;
                        bool rightPossible = true ? targetToRemove + radius < targets.Count : false;
                        int startIndexLeft = targetToRemove - radius;

                        if (leftPossible && rightPossible)
                        {
                            for (int i = 0; i < radius; i++)
                            {
                                targets.RemoveAt(startIndexLeft);
                            }
                            targetToRemove -= radius;
                            for (int i = 0; i < radius; i++)
                            {
                                targets.RemoveAt(targetToRemove + 1);
                            }
                            targets.RemoveAt(targetToRemove);

                        }
                        else
                        {
                            Console.WriteLine("Strike missed!");
                        }
                        break;
                    case "End":
                        Console.WriteLine(string.Join("|",targets));
                        return;
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine().Split();
            }
        }
    }
}
