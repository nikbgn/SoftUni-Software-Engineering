using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {

            Stack<int> stack = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            int rackCapacity = int.Parse(Console.ReadLine());
            int sumOfValues = 0;
            int racksUsed = 1;
            while (stack.Count > 0)
            {
                int currentCloth = stack.Peek();
                if (sumOfValues + currentCloth <= rackCapacity)
                {
                    sumOfValues += stack.Pop();
                }
                else
                {
                    racksUsed++;
                    sumOfValues = 0;
                }

            }
            Console.WriteLine(racksUsed);
            
        }
    }
}
