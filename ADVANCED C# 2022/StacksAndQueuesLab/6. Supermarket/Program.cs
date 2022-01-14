using System;
using System.Collections.Generic;

namespace _6._Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            
            while(true)
            {
                string currCmd = Console.ReadLine();
                if (currCmd == "Paid")
                {
                    while (queue.Count > 0)
                    {
                        Console.WriteLine(queue.Dequeue());
                    }
                }
                else if (currCmd == "End")
                {
                    Console.WriteLine($"{queue.Count} people remaining.");
                    return;
                }
                else queue.Enqueue(currCmd);
                
            }
        }
    }
}
