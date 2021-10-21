using System;

namespace _07.HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            double priceStudio = 0;
            double priceApartment = 0;

            switch (month)
            {
                case "May":
                case "October":
                    priceStudio = days * 50;
                    priceApartment = days * 65;
                    if (7 < days && days < 14)
                    {
                        priceStudio = priceStudio - priceStudio * 0.05;
                    }
                    else if (days > 14)
                    {
                        priceStudio = priceStudio - priceStudio * 0.3;
                        priceApartment = priceApartment - priceApartment * 0.1;
                    }
                    break;
                case "June":
                case "September":
                    priceStudio = days * 75.20;
                    priceApartment = days * 68.70;
                    if (days > 14)
                    {
                        priceStudio = priceStudio - priceStudio * 0.2;
                        priceApartment = priceApartment - priceApartment * 0.1;
                    }
                    break;
                case "August":
                case "July":
                    priceStudio = days * 76;
                    priceApartment = days * 77;
                    if (days > 14)
                    {
                        priceApartment = priceApartment - priceApartment * 0.1;
                    }
                    break;
            }
            Console.WriteLine($"Apartment: {priceApartment:F2} lv.");
            Console.WriteLine($"Studio: {priceStudio:F2} lv.");
        }
    }
}