using System;

namespace _06._Tournament_of_Christmas
{
    class Program
    {
        static void Main(string[] args)
        {
            //INPUT FROM THE CONSOLE:
            int days = int.Parse(Console.ReadLine());
            int countOfWins = 0;
            int countOfLoses = 0;
            int countOfWinDays = 0;
            int countOfLoseDays = 0;
            double countMoneyEarned = 0;
            double totalMoney = 0;
            for (int day = 1; day <= days; day++)
            {
                string input = Console.ReadLine();
                while (input != "Finish")
                {
                    string argument = Console.ReadLine();
                    if (argument == "win")
                    {
                        countOfWins++;
                        countMoneyEarned += 20;
                    }
                    else
                    {
                        countOfLoses++;
                    }
                    input = Console.ReadLine();

                }
                if (countOfWins > countOfLoses)
                {
                    countMoneyEarned = countMoneyEarned + (0.1 * countMoneyEarned);
                    countOfWinDays++;
                }
                else
                {
                    countOfLoseDays++;
                }
                totalMoney += countMoneyEarned;
                countMoneyEarned = 0;
                countOfWins = 0;
                countOfLoses = 0;
            }

            if (countOfWinDays > countOfLoseDays)
            {
                totalMoney += 0.2 * totalMoney;
                Console.WriteLine($"You won the tournament! Total raised money: {totalMoney:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {totalMoney:f2}");
            }
        }
    }
}
