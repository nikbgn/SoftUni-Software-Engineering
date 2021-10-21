using System;

namespace _03._Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int prime = 0;
            int notPrime = 0;
            bool hasNegative = false;
            while (command != "stop")
            {
                int number = int.Parse(command);
                if (number < 0) { hasNegative = true; }
                else
                {

                    int count = 0;
                    for (int i = 1; i <=number; i++)
                    {
                        if (number % i == 0) { count++; }
                    }
                    if (count == 2) { prime += number; }
                    else { notPrime += number; }
                }
                command = Console.ReadLine();
            }

            if (hasNegative) { Console.WriteLine($"Number is negative.\r\nSum of all prime numbers is: {prime}\r\nSum of all non prime numbers is: {notPrime}"); }
            else { Console.WriteLine($"Sum of all prime numbers is: {prime}\r\nSum of all non prime numbers is: {notPrime}"); }
            
        }
    }
}
