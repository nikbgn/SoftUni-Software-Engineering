using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)

        {
            string cashAdd = Console.ReadLine();
            double balance = 0;
            double nutsPrice = 2.0;
            double waterPrice = 0.7;
            double crispsPrice = 1.5;
            double sodaPrice = 0.8;
            double cokePrice = 1.0;

            while (cashAdd != "Start")
            {
                switch (cashAdd)
                {
                    case "2":
                    case "1":
                    case "0.5":
                    case "0.2":
                    case "0.1":
                        balance += double.Parse(cashAdd);
                        break;
                    default:
                        Console.WriteLine($"Cannot accept {cashAdd}");
                        break;
                }
                cashAdd = Console.ReadLine();
            }

            string product = Console.ReadLine();

            while (product != "End")
            {
                switch (product)
                {
                    case "Nuts":
                        if (balance - nutsPrice < 0)
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        else
                        {
                            Console.WriteLine($"Purchased {product.ToLower()}");
                            balance -= nutsPrice;
                        }
                        break;

                    case "Water":
                        if (balance - waterPrice < 0)
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        else
                        {
                            Console.WriteLine($"Purchased {product.ToLower()}");
                            balance -= waterPrice;
                        }
                        break;

                    case "Crisps":
                        if (balance - crispsPrice < 0)
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        else
                        {
                            Console.WriteLine($"Purchased {product.ToLower()}");
                            balance -= crispsPrice;
                        }
                        break;


                    case "Soda":
                        if (balance - sodaPrice < 0)
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        else
                        {
                            Console.WriteLine($"Purchased {product.ToLower()}");
                            balance -= sodaPrice;
                        }
                        break;


                    case "Coke":
                        if (balance - cokePrice < 0)
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        else
                        {
                            Console.WriteLine($"Purchased {product.ToLower()}");
                            balance -= cokePrice;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }

                product = Console.ReadLine();
            }
            Console.WriteLine($"Change: {balance:F2}");

        }

    }
}

