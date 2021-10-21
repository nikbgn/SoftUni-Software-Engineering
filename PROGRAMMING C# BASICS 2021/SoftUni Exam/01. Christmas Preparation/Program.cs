using System;

namespace _01._Christmas_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prices
            double opakovuchna_hartiq_cena_rolka = 5.80;
            double plat_cena_rolka = 7.20;
            double lepilo_cena_litur = 1.20;
            //INPUT:
            int rolki_Hartiq = int.Parse(Console.ReadLine());
            int rolki_Plat = int.Parse(Console.ReadLine());
            double litri_Lepilo = double.Parse(Console.ReadLine());
            int namalenie_procent = int.Parse(Console.ReadLine());

            double cena_hartiq = rolki_Hartiq * opakovuchna_hartiq_cena_rolka;
            double cena_plat = plat_cena_rolka * rolki_Plat;
            double cena_lepilo = lepilo_cena_litur * litri_Lepilo;

            double everything = cena_hartiq + cena_plat + cena_lepilo;
            
            everything -= everything * (1.0*namalenie_procent/100);
            Console.WriteLine($"{everything:f3}");
        }
    }
}
