using System;
using System.Collections.Generic;

namespace _8._Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {

            Queue<string> traffic = new Queue<string>();
            int numOfCarsThatCanPassOnGreenLight = int.Parse(Console.ReadLine());
            int countOfCarsThatPassed = 0;
            while (true)
            {
                string currCommand = Console.ReadLine();
                if (currCommand == "green")
                {
                    if(traffic.Count >= numOfCarsThatCanPassOnGreenLight)
                    {
                        for (int i = 0; i < numOfCarsThatCanPassOnGreenLight; i++)
                        {
                            Console.WriteLine($"{traffic.Dequeue()} passed!");
                            countOfCarsThatPassed++;
                        }
                    }
                    else
                    {
                        while(traffic.Count > 0)
                        {
                            Console.WriteLine($"{traffic.Dequeue()} passed!");
                            countOfCarsThatPassed++;
                        }
                    }
                }
                else if(currCommand == "end")
                {
                    Console.WriteLine($"{countOfCarsThatPassed} cars passed the crossroads.");
                    return;
                }
                else
                {
                    traffic.Enqueue(currCommand);
                }
                

            }


        }
    }
}
