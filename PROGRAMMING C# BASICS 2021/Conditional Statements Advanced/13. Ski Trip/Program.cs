using System;

namespace _13._Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            const double ROOM_FOR_ONE_PERSON = 18.00;
            const double APARTMENT = 25.00;
            const double PRESIDENT_APARTMENT = 35.00;

            int days = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string feedback = Console.ReadLine();

            switch (roomType)
            {
                case "room for one person":
                    double finalPrice = (days - 1) * ROOM_FOR_ONE_PERSON;
                    Console.WriteLine(finalPrice);

                    break;

                case "apartment":
                    if (days < 10)
                    {
                        double shouldPay = ((days - 1) * APARTMENT);
                        double discoutPrice;
                    }
                    break;

            }
        }
    }
}
