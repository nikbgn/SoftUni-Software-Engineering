using System;

namespace _12._Trade_Commissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());

            switch (city)
            {

                case "Sofia":
                    if (sales > 0 && sales <= 500)
                    {
                        Console.WriteLine($"{sales * .05:F2}");
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        Console.WriteLine($"{sales * .07:F2}");
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        Console.WriteLine($"{sales * .08:F2}");
                    }
                    else if (sales > 10000)
                    {
                        Console.WriteLine($"{sales * .12:F2}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }

                    break;
                case "Varna":
                    if (sales > 0 && sales <= 500)
                    {
                        Console.WriteLine($"{sales * .045:F2}"); //Varna	4.5%	7.5%	10%	13%
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        Console.WriteLine($"{sales * .075:F2}");
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        Console.WriteLine($"{sales * .1:F2}");
                    }
                    else if (sales > 10000)
                    {
                        Console.WriteLine($"{sales * .13:F2}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;

                case "Plovdiv":
                    if (sales > 0 && sales <= 500)
                    {
                        Console.WriteLine($"{sales * .055:F2}"); //Plovdiv	5.5%	8%	12%	14.5%
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        Console.WriteLine($"{sales * .08:F2}");
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        Console.WriteLine($"{sales * .12:F2}");
                    }
                    else if (sales > 10000)
                    {
                        Console.WriteLine($"{sales * .145:F2}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
        }
    }
}
