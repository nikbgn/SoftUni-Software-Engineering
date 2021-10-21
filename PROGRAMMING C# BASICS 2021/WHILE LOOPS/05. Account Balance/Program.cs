using System;

namespace _05._Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double balance = 0.0;

            while (input != "NoMoreMoney")
            {
                double amount = double.Parse(input);
                if (amount < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                balance += amount;
                Console.WriteLine($"Increase: {amount:f2}");
                input = Console.ReadLine();

            }

            Console.WriteLine($"Total: {balance:f2}");
        }
    }
}
