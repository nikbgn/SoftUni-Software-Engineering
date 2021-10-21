using System;

namespace _03._New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            //&quot;Roses&quot;, &quot;Dahlias&quot;, &quot;Tulips&quot;, &quot;Narcissus&quot;, &quot;Gladiolus&quot;
            string flower = Console.ReadLine();
            int flowerCount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());


            switch (flower)
            {
                case "Roses":
                    double price = 5 * flowerCount;
                    if (flowerCount > 80)
                    {
                        price = price - price * 0.1;
                    }
                    if (budget >= price)
                    {
                        Console.WriteLine($"Hey, you have a great garden with {flowerCount} {flower} and {budget - price:F2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money, you need {price - budget:F2} leva more.");
                    }
                    break;
                case "Dahlias":
                    double dahilPrice = 3.80 * flowerCount;
                    if (flowerCount > 90)
                    {
                        dahilPrice = dahilPrice - dahilPrice * 0.15;
                    }
                    if (budget >= dahilPrice)
                    {
                        Console.WriteLine($"Hey, you have a great garden with {flowerCount} {flower} and {budget - dahilPrice:F2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money, you need {dahilPrice - budget:F2} leva more.");
                    }
                    break;

                case "Tulips":
                    double tulipsPrice = 2.80 * flowerCount;
                    if (flowerCount > 80)
                    {
                        tulipsPrice = tulipsPrice - tulipsPrice * 0.15;
                    }
                    if (budget >= tulipsPrice)
                    {
                        Console.WriteLine($"Hey, you have a great garden with {flowerCount} {flower} and {budget - tulipsPrice:F2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money, you need {tulipsPrice - budget:F2} leva more.");
                    }
                    break;

                case "Narcissus":
                    double narcPrice = 3 * flowerCount;
                    if (flowerCount < 120)
                    {
                        narcPrice += narcPrice * 0.15;
                    }
                    if (budget >= narcPrice)
                    {
                        Console.WriteLine($"Hey, you have a great garden with {flowerCount} {flower} and {budget - narcPrice:F2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money, you need {narcPrice - budget:F2} leva more.");
                    }
                    
                    break;
                case "Gladiolus":
                    double Gladious = 2.50 * flowerCount;
                    if (flowerCount < 80)
                    {
                        Gladious += Gladious * 0.2;
                    }
                    if (budget >= Gladious)
                    {
                        Console.WriteLine($"Hey, you have a great garden with {flowerCount} {flower} and {budget - Gladious:F2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money, you need {Gladious - budget:F2} leva more.");
                    }

                    break;


            }
        }
    }
}
