using System;

namespace _01._Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            int countTickets = rows * cols;
            double ticketPrice = 0;

            switch (type)
            {
                case "Premiere":
                    ticketPrice = 12;
                    break;
                case "Normal":
                    ticketPrice = 7.50;
                    break;
                case "Discount":
                    ticketPrice = 5.00;
                    break;
            }

            Console.WriteLine($"{countTickets*ticketPrice:F2} leva");
        }
    }
}
