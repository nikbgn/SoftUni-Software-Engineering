using System;

namespace PB_MORE_EXERCISES_FOR_LOOPS
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int age = 18;

            for (int curYear = 1800; curYear <=year; curYear++)
            {
                if (curYear % 2 == 0) { money -= 12000; }
                else { money -= 12000 + (50 * age); }
                age++;
            }

            if (money >= 0) { Console.WriteLine($"Yes! He will live a carefree life and will have {money:f2} dollars left."); }
            else { Console.WriteLine($"He will need {Math.Abs(money):f2} dollars to survive."); }
        }
    }
}
