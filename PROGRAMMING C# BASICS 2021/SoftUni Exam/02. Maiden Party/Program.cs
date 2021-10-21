using System;

namespace _02._Maiden_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prices
            double lubovno_poslanie_cena = 0.60;
            double vosuchna_roza_cena = 7.20;
            double kluchodurjatel_cena = 3.60;
            double karikatura_cena = 18.20;
            double kusmet_iznenada_cena = 22;
            //INPUT

            double partyPrice = double.Parse(Console.ReadLine());
            int count_lubovno_poslanie = int.Parse(Console.ReadLine());
            int count_vosuchni_rozi = int.Parse(Console.ReadLine());
            int count_kluchodurjateli = int.Parse(Console.ReadLine());
            int count_karikaturi = int.Parse(Console.ReadLine());
            int count_kusmeti_iznenada = int.Parse(Console.ReadLine());

            //LOGIC

            double overallPrice = count_lubovno_poslanie * lubovno_poslanie_cena + count_vosuchni_rozi * vosuchna_roza_cena + count_kluchodurjateli * kluchodurjatel_cena + count_karikaturi * karikatura_cena + kusmet_iznenada_cena * count_kusmeti_iznenada;
            double overallSum = count_karikaturi + count_kluchodurjateli + count_kusmeti_iznenada + count_lubovno_poslanie + count_vosuchni_rozi;
            double hosting = 0;
            double finalCash = 0;

            if (overallSum >= 25)
            {
                overallPrice = overallPrice - overallPrice * 0.35;
                hosting = overallPrice * 0.10;

                finalCash = overallPrice - hosting;

            }

            else
            {
                hosting = overallPrice * 0.10;
                finalCash = overallPrice - hosting;
            }

            if (finalCash >= partyPrice) { Console.WriteLine($"Yes! {finalCash-partyPrice:f2} lv left."); }
            else { Console.WriteLine($"Not enough money! {Math.Abs(finalCash-partyPrice):f2} lv needed."); }

        }
    }
}
