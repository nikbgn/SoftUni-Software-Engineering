using System;

namespace _07._World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double timeInSeconds = double.Parse(Console.ReadLine());

            double timeToSwim = distanceInMeters * timeInSeconds; //Na teoriq pluva tolkova
            double realTimeToSwim = Math.Floor(distanceInMeters / 15) * 12.5; // Realno se zabavq poradi umora
            double timeOverall = timeToSwim + realTimeToSwim; // Vremeto na teoriq + smetnatoto zabavqne ot umorata ni davat istinskoto vreme za koeto shte prepluva

            if (timeOverall < recordInSeconds)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {timeOverall:F2} seconds.");
            }

            else
            {
                double secsLeft = timeOverall - recordInSeconds;
                Console.WriteLine($"No, he failed! He was {secsLeft:F2} seconds slower.");
            }

        }
    }
}
