using System;

namespace _11._Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string weekDay = Console.ReadLine();
            double qty = double.Parse(Console.ReadLine());

            switch (weekDay)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    if (fruit == "banana")
                    {
                        Console.WriteLine($"{qty*2.50:F2}");
                    }
                    else if (fruit == "apple") {
                        Console.WriteLine($"{qty * 1.20:F2}");
                    }
                    else if (fruit == "orange")
                    {
                        Console.WriteLine($"{qty * 0.85:F2}");
                    }
                    else if (fruit == "grapefruit")
                    {
                        Console.WriteLine($"{qty * 1.45:F2}");
                    }
                    else if (fruit == "kiwi")
                    {
                        Console.WriteLine($"{qty * 2.70:F2}");
                    }
                    else if (fruit == "pineapple")
                    {
                        Console.WriteLine($"{qty * 5.50:F2}");
                    }
                    else if (fruit == "grapes")
                    {
                        Console.WriteLine($"{qty * 3.85:F2}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                case "Saturday":
                case "Sunday":
                    if (fruit == "banana")
                    {
                        Console.WriteLine($"{qty * 2.70:F2}");
                    }
                    else if (fruit == "apple")
                    {
                        Console.WriteLine($"{qty * 1.25:F2}");
                    }
                    else if (fruit == "orange")
                    {
                        Console.WriteLine($"{qty * 0.90:F2}");
                    }
                    else if (fruit == "grapefruit")
                    {
                        Console.WriteLine($"{qty * 1.60:F2}");
                    }
                    else if (fruit == "kiwi")
                    {
                        Console.WriteLine($"{qty * 3.00:F2}");
                    }
                    else if (fruit == "pineapple")
                    {
                        Console.WriteLine($"{qty * 5.60:F2}");
                    }
                    else if (fruit == "grapes")
                    {
                        Console.WriteLine($"{qty * 4.20:F2}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    //цена	2.70	1.25	0.90	1.60	3.00	5.60	4.20


                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
        }
    }
}
