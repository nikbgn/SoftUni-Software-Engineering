using System;

namespace _01PROBLEM_Computer_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            //Judge points 100/100

            double totalPrice = 0;
            string command = Console.ReadLine();


            while (true)
            {
                if (command == "special" || command == "regular") break;
                double price = double.Parse(command);
                if (price < 0) Console.WriteLine("Invalid price!");
                else { totalPrice += price; }
                command = Console.ReadLine();
            }

            switch (command)
            {
                case "special":
                    if (totalPrice == 0) Console.WriteLine("Invalid order!");
                    else
                    {
                        double originalPrice = totalPrice;
                        totalPrice += totalPrice * 0.2;
                        totalPrice -= totalPrice * 0.1;//Discount
                        Console.WriteLine($"Congratulations you've just bought a new computer!\nPrice without taxes: {originalPrice:f2}$\nTaxes: {originalPrice*0.2:f2}$\n-----------\nTotal price: {totalPrice:f2}$");
                    }
                    break;
                case "regular":
                    if (totalPrice == 0) Console.WriteLine("Invalid order!");
                    else
                    {
                        double originalPrice = totalPrice;
                        totalPrice += totalPrice * 0.2;
                        Console.WriteLine($"Congratulations you've just bought a new computer!\nPrice without taxes: {originalPrice:f2}$\nTaxes: {originalPrice * 0.2:f2}$\n-----------\nTotal price: {totalPrice:f2}$");
                    }
                    break;
                default:
                    break;
            }




        }
    }
}
