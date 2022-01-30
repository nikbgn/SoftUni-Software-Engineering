using System;


namespace _02.KnightsofHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string[]> SirPrinter = (knightsNames) => Console.WriteLine("Sir " + string.Join(Environment.NewLine + "Sir ",knightsNames));
            string[] names = Console.ReadLine().Split();
            SirPrinter(names);
        }
    }
}
