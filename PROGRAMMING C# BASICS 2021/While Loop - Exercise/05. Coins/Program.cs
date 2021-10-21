using System;

namespace _05._Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double change = double.Parse(Console.ReadLine());
            double changeInSt = Math.Floor(change * 100);
            int countMoney = 0;
            int dvuLevki = 0;
            int ednoLevki = 0;
            int petdesetStotinki = 0;
            int dvadesetStotinki = 0;
            int desetStotinki = 0;
            int petStotinki = 0;
            int dveStotinki = 0;
            int ednaStotinka = 0;
            while (changeInSt > 0)
            {
                if (changeInSt >= 200)
                {
                    changeInSt -= 200;
                    countMoney++;
                    dvuLevki++;
                }
                else if (changeInSt >= 100)
                {
                    changeInSt -= 100;
                    countMoney++;
                    ednoLevki++;
                }
                else if (changeInSt >= 50)
                {
                    changeInSt -= 50;
                    countMoney++;
                    petdesetStotinki++;
                }
                else if (changeInSt >= 20)
                {
                    changeInSt -= 20;
                    countMoney++;
                    dvadesetStotinki++;
                }
                else if (changeInSt >= 10)
                {
                    changeInSt -= 10;
                    countMoney++;
                    desetStotinki++;
                }
                else if (changeInSt >= 5)
                {
                    changeInSt -= 5;
                    countMoney++;
                    petStotinki++;
                }
                else if (changeInSt >= 2)
                {
                    changeInSt -= 2;
                    countMoney++;
                    dveStotinki++;
                    
                }
                else if (changeInSt >= 1)
                {
                    changeInSt -= 1;
                    countMoney++;
                    ednaStotinka++;
                }


            }

            Console.WriteLine($"Общ брой нужни монети: {countMoney}");
            Console.WriteLine($"Монети от 2 лева: {dvuLevki}\r\nМонети от 1 лев: {ednoLevki}\r\nМонети от 50 стотинки: {petdesetStotinki}\r\nМонети от 20 стотинки: {dvadesetStotinki}\r\nМонети от 10 стотинки: {desetStotinki}\r\nМонети от 5 стотинки: {petStotinki}\r\nМонети от 2 стотинки: {dveStotinki}\r\nМонети от 1 стотинка: {ednaStotinka}");
        }
    }
}
