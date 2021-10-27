using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNumGenerator = new Random();
            List<string> userInput = Console.ReadLine().Split().ToList();
            while (userInput.Count > 0)
            {
                string item = userInput[randomNumGenerator.Next(0, userInput.Count)];
                Console.WriteLine(item);
                userInput.Remove(item);
            }
        }
    }
}
