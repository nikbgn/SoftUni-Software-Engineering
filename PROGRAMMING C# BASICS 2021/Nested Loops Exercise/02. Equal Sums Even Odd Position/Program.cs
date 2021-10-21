using System;

namespace _02._Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int fNum = int.Parse(Console.ReadLine());
            int sNum = int.Parse(Console.ReadLine());

            for (int number = fNum; number <= sNum; number++)
            {
                //Figure out the positions
                int pos1 = number / 100000;
                int pos2 = number/10000 % 10;
                int pos3 = number / 1000 % 10;
                int pos4 = number / 100 % 10;
                int pos5 = number / 10 % 10;
                int pos6 = number % 10;

                //Sum
                int sumEven = pos2 + pos4 + pos6;
                int sumOdd = pos1 + pos3 + pos5;
                //If check if the sums are equal
                if (sumEven == sumOdd) { Console.Write(number + " "); }
            }
        }
    }
}
