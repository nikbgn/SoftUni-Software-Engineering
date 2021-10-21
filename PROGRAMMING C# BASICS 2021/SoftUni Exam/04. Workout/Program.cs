using System;

namespace _04._Workout
{
    class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            int daysCount = int.Parse(Console.ReadLine());
            double kilometersRanFirstDay = double.Parse(Console.ReadLine());
            double overallKilometers = kilometersRanFirstDay;
            double lastRan = kilometersRanFirstDay;
            for (int i = 0; i < daysCount; i++)
            {
                
                int addedKilo = int.Parse(Console.ReadLine());
                double kiloToPercent = addedKilo * 1.0 / 100; //0.1
                
                
                double toAddUp = lastRan + kiloToPercent * lastRan;
                overallKilometers += toAddUp;
                lastRan = toAddUp;
                //Console.WriteLine((addedKilo * 1.0) / 100);
            }

            if (overallKilometers < 1000)
            {
                Console.WriteLine($"Sorry Mrs. Ivanova, you need to run {Math.Ceiling(1000-overallKilometers)} more kilometers");
            }
            else
            {
                Console.WriteLine($"You've done a great job running {Math.Ceiling(overallKilometers-1000)} more kilometers!");
            }
        }
    }
}
