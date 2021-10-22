using System;

namespace _09._Yard_Greening
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input:
            double kvMetri = double.Parse(Console.ReadLine());
            //Constants:
            double cena = 7.61;
            double discount = 0.18;
            //Calculations
            double finalPrice = kvMetri * cena;
            double discountPrice = discount * finalPrice;
            double result = finalPrice - discountPrice;
            Console.WriteLine($"The final price is: {result} lv.");
            Console.WriteLine($"The discount is: {discountPrice} lv.");
            //Ozelenihme dvorovete na Bojidara
        }
    }
}
