using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {



            List<int> intList = Console.ReadLine().Split().Select(int.Parse).ToList();
            string cmd = string.Empty;
            int num = 0;
            int item = 0;
            while (true)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "end")
                {
                    Console.WriteLine(string.Join(" ", intList));
                    return;
                }
                
                if (command.Length == 3)
                {
                    cmd = command[0];
                    num = int.Parse(command[1]);
                    item = int.Parse(command[2]);

                }
                else
                {
                    cmd = command[0];
                    num = int.Parse(command[1]);
                }

                switch (cmd)
                {
                    case "Add":
                        intList.Add(num);
                        break;
                    case "Remove":
                        intList.Remove(num);
                        break;
                    case "RemoveAt":
                        intList.RemoveAt(num);
                        break;
                    case "Insert":
                        intList.Insert(item, num);
                        break;
                    default:
                        break;
                }
            }

        }
    }
}
