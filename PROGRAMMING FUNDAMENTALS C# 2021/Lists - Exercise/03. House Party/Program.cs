using System;
using System.Collections.Generic;
using System.Linq;
namespace _03._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfLines = int.Parse(Console.ReadLine());
            List<string> people = new List<string>() { };


            for (int i = 0; i < numOfLines; i++)
            {
                List<string> command = Console.ReadLine().Split().ToList();
                //Command example:


                //Command[2] value will be either "going" or "not"
                if (command[2] == "going!")
                {
                    if (people.Contains(command[0]))
                    {
                        Console.WriteLine($"{command[0]} is already in the list!");
                    }
                    else
                    {
                        people.Add(command[0]);

                    }
                }
                else
                {
                    if (people.Contains(command[0]) == false)
                    {
                        Console.WriteLine($"{command[0]} is not in the list!");
                    }
                    else
                    {
                        people.Remove(command[0]);
                    }
                }


            }

            foreach (string person in people)
            {
                Console.WriteLine(person);
            }
        }
    }
}
