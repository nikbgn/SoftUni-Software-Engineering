using System;

namespace _08._Pet_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вход от конзолата
            //1. Броят на кучетата - инт
            int dogsCount = int.Parse(Console.ReadLine());
            //2. Броят на останалите животни - инт:
            int otherAnimalsCount = int.Parse(Console.ReadLine());
            //Logic:
            double foodForDogPrice = dogsCount * 2.50;
            double foodForOther = otherAnimalsCount * 4;

            double result = foodForDogPrice + foodForOther;
            Console.WriteLine($"{result} lv.");
        }
    }
}
