using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resources = new Dictionary<string, int>();
            string commandKey = Console.ReadLine();
            while (commandKey != "stop")
            {
                int qty = int.Parse(Console.ReadLine());

                if (!resources.ContainsKey(commandKey))
                {
                    resources.Add(commandKey, 0);
                }

                resources[commandKey] += qty;


                commandKey = Console.ReadLine();
            }
            foreach (var item in resources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
