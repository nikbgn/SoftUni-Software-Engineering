using System;

namespace _03._Mobile_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            string moviePacket = Console.ReadLine();
            int tickets = int.Parse(Console.ReadLine());

            switch (movie)
            {
                case "John Wick":
                    if (moviePacket == "Drink") { Console.WriteLine($"Your bill is {tickets*12:f2} leva."); }
                    else if (moviePacket == "Popcorn") { Console.WriteLine($"Your bill is {tickets * 15:f2} leva."); }
                    else if (moviePacket == "Menu"){ Console.WriteLine($"Your bill is {tickets * 19:f2} leva."); } 
                    break;
                case "Star Wars":

                    if (tickets >= 4)
                    {
                        if (moviePacket == "Drink")
                        {
                            double discountDrink = (tickets * 18) - (tickets * 18) * .3;
                            Console.WriteLine($"Your bill is {discountDrink:f2} leva.");
                        }
                        else if (moviePacket == "Popcorn")
                        {
                            double discountPopcorn = (tickets * 25) - (tickets * 25) * .3;
                            Console.WriteLine($"Your bill is {discountPopcorn:f2} leva.");
                        }
                        else
                        {
                            double discountMenu = (tickets * 30) - (tickets * 30) * .3;
                            Console.WriteLine($"Your bill is {discountMenu:f2} leva.");
                        }
                        break;

                    }
                    if (moviePacket == "Drink")
                    {
                        //double discountDrink = (tickets * 18) - (tickets * 18) * .3;
                        Console.WriteLine($"Your bill is {tickets * 18:f2} leva.");
                    }
                    else if (moviePacket == "Popcorn")
                    {
                        //double discountPopcorn = (tickets * 25) - (tickets * 25) * .3;
                        Console.WriteLine($"Your bill is {tickets * 25:f2} leva.");
                    }
                    else
                    {
                        //double discountMenu = (tickets * 30) - (tickets * 30) * .3;
                        Console.WriteLine($"Your bill is {tickets * 30:f2} leva.");
                    }



                    break;
                case "Jumanji":
                    if (tickets == 2)
                    {
                        if (moviePacket == "Drink")
                        {
                            double discountDrink = (tickets * 9) - (tickets * 9) * .15;
                            Console.WriteLine($"Your bill is {discountDrink:f2} leva.");
                        }

                        else if (moviePacket == "Popcorn")
                        {
                            double discountPopcorn = (tickets * 11) - (tickets * 11) * .15;
                            Console.WriteLine($"Your bill is {discountPopcorn:f2} leva.");
                        }

                        else
                        {
                            double discountMenu = (tickets * 14) - (tickets * 14) * .15;
                            Console.WriteLine($"Your bill is {discountMenu:f2} leva.");
                        }
                        break;
                    }

                    if (moviePacket == "Drink")
                    {
                        //double discountDrink = (tickets * 9) - (tickets * 9) * .15;
                        Console.WriteLine($"Your bill is {tickets*9:f2} leva.");
                    }

                    else if (moviePacket == "Popcorn")
                    {
                        //double discountPopcorn = (tickets * 11) - (tickets * 11) * .15;
                        Console.WriteLine($"Your bill is {tickets*11:f2} leva.");
                    }

                    else
                    {
                        //double discountMenu = (tickets * 14) - (tickets * 14) * .15;
                        Console.WriteLine($"Your bill is {tickets*14:f2} leva.");
                    }

                    break;
            }
        }
    }
}
