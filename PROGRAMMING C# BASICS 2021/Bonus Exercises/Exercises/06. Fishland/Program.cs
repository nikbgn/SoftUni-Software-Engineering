using System;

namespace _06._Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double skumriqKG = double.Parse(Console.ReadLine());
            double cacaKG = double.Parse(Console.ReadLine());
            double palamud = double.Parse(Console.ReadLine());
            double safrid = double.Parse(Console.ReadLine());
            int midi = int.Parse(Console.ReadLine());

            double midiKgPrice = 7.50;
            double PalamudKgPrice = skumriqKG + skumriqKG * 0.6;
            double safridKgPrice = cacaKG + cacaKG * 0.8;

            double palamudFinal = palamud * PalamudKgPrice;
            double safridFinal = safrid * safridKgPrice;
            double midiFinal = midi * midiKgPrice;

            double output = palamudFinal + safridFinal + midiFinal;
            Console.WriteLine($"{output:F2}");



        }
    }
}
