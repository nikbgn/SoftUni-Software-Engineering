using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string typeGroup = Console.ReadLine();
            string dayWeek = Console.ReadLine();
            double toPay = 0;
            switch (typeGroup)
            {
                case "Students":
                    if (dayWeek == "Friday") { toPay += people * 8.45; }
                    else if (dayWeek == "Saturday") { toPay += people * 9.80; }
                    else if (dayWeek == "Sunday") { toPay += people * 10.46; }
                    if (people >= 30) { toPay -= toPay * 0.15; }
                    break;
                case "Business":
                    if (dayWeek == "Friday" && people>=100) { toPay += (people-10) * 10.90; }
                    else if (dayWeek == "Friday") { toPay += people * 10.90; }
                    else if (dayWeek == "Saturday" && people>=100) { toPay += (people-10) * 15.60; }
                    else if (dayWeek == "Saturday") { toPay += people * 15.60; }
                    else if (dayWeek == "Sunday" && people>=100) { toPay += (people-10) * 16; }
                    else if (dayWeek == "Sunday" ) { toPay += people * 16; }

                    break;
                case "Regular":
                    if (dayWeek == "Friday") { toPay += people * 15; }
                    else if (dayWeek == "Saturday") { toPay += people * 20; }
                    else if (dayWeek == "Sunday") { toPay += people * 22.50; }
                    if (people >= 10 && people <= 20) { toPay -= toPay * 0.05; }
                    break;
                default:
                    Console.WriteLine("Spek");
                    break;
            }

            Console.WriteLine($"Total price: {toPay:F2}");
        }
    }
}
