using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            string line = Console.ReadLine();

            while (line != "end")
            {

                string[] tokens = line.Split();
                string command = tokens[0];
                string commandValue = tokens[1];

                if (command == "Delete")
                {
                    int element = int.Parse(commandValue);
                    
                    nums.RemoveAll(el => el == element);//Vsqko edno chislo ot nashiq list, ako e == na element, go trii


                }
                else if (command == "Insert")
                {
                    int element = int.Parse(commandValue);
                    int index = int.Parse(tokens[2]);
                    nums.Insert(index, element);
                }

                line = Console.ReadLine();
            }


            Console.WriteLine(string.Join(" ",nums));


        }
    }
}
