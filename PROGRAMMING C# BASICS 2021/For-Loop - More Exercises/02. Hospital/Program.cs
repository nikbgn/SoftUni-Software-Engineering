using System;

namespace _02._Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());
            int doctors = 7;
            int peopleChecked = 0;
            int peopleUnchecked = 0;

            for (int daysPassed = 1; daysPassed <= period; daysPassed++)
            {
                int dailyPatients = int.Parse(Console.ReadLine());
                if (daysPassed % 3 == 0 && peopleChecked < peopleUnchecked) { doctors += 1; }

                if (doctors >= dailyPatients) { peopleChecked += dailyPatients; }

                else if (doctors < dailyPatients){ peopleChecked += doctors; peopleUnchecked += dailyPatients - doctors; }

            }

            Console.WriteLine($"Treated patients: {peopleChecked}.");
            Console.WriteLine($"Untreated patients: {peopleUnchecked}.");
        }
    }
}
