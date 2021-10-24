using System;

namespace CSharpTestMidPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem: 01. Black Flag
            //Judge Points 100/100
            //Inputs:
            int daysOfPlunder = int.Parse(Console.ReadLine());
            int dailyPlunder = int.Parse(Console.ReadLine());
            double target = double.Parse(Console.ReadLine());

            double totalPlunder = 0;


            //Logic:

            //For every day in daysOfPlunder
            for (int day = 1; day <= daysOfPlunder; day++)
            {
                //If its everyThirdDay totalPlunder += dailyPlunder and 50% of daily plunder;

                totalPlunder += dailyPlunder;
                if (day % 3 == 0)
                {
                    totalPlunder += dailyPlunder * 0.5;
                }
                //If its everyFifthDay totalPlunder -= 30% of totalPlunder;
                if (day % 5 == 0)
                {
                    //totalPlunder += dailyPlunder;
                    //Console.WriteLine($"VALUE OF TOTALPLUNDER{totalPlunder} * 0.3 = {totalPlunder*0.3}");
                    totalPlunder -= totalPlunder * 0.3;
                }


            }

            //If totalPlunder >= target => print the success message.
            if (totalPlunder >= target)
            {
                Console.WriteLine($"Ahoy! {totalPlunder:f2} plunder gained.");
            }
            //Else totalPlunder < target => print the failed message.
            else
            {
                Console.WriteLine($"Collected only {(totalPlunder / target) * 100:f2}% of the plunder.");
            }



        }
    }
}
