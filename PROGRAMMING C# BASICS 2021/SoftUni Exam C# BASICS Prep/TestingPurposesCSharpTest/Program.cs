using System;

namespace ExamPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            const double BITCOIN_TO_BGN = 1168;
            const double CHINEESEJUAN_TO_DOLLAR = 0.15;
            const double DOLLAR_TO_BGN = 1.76;
            const double EURO_TO_BGN = 1.95;

            int btc = int.Parse(Console.ReadLine());
            double chineeseJuanNumber = double.Parse(Console.ReadLine());
            double commission = double.Parse(Console.ReadLine());

            double bitcoinSum = BITCOIN_TO_BGN * btc;
            double juanSum = CHINEESEJUAN_TO_DOLLAR * chineeseJuanNumber;
            double juanInLeva = juanSum * DOLLAR_TO_BGN;
            double euro = (bitcoinSum + juanInLeva) / EURO_TO_BGN;
            commission /= 100;
            double result = euro - euro * commission;
            Console.WriteLine($"{result:f2}");



        }
    }
}
