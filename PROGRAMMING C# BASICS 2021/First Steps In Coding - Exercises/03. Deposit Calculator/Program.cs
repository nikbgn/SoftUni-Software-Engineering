using System;

namespace _03._Deposit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double depoziranaSuma = double.Parse(Console.ReadLine());
            int srokMeseci = int.Parse(Console.ReadLine());
            double godishenLihvenProcent = double.Parse(Console.ReadLine());

            double final = depoziranaSuma + srokMeseci * ((depoziranaSuma * godishenLihvenProcent * 0.01) / 12);
            Console.WriteLine(final);

        }
    }
}
