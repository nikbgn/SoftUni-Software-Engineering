using System;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(getMultipleOfEvensAndOdds(a));
        }



        static int getSumOfEvenDigits(int number)
        {
            int result = 0;
            int workNum = Math.Abs(number);
            string numSize = workNum.ToString();
            for (int i = 0; i < numSize.Length; i++)
            {
                int numLastDigit = workNum % 10;
                if (numLastDigit % 2 == 0) { result += numLastDigit; }
                workNum /= 10;
            }
            return result;
        }


        static int getSumOfOddDigits(int number)
        {
            int result = 0;
            int workNum = Math.Abs(number);
            string numSize = workNum.ToString();
            for (int i = 0; i < numSize.Length; i++)
            {
                int numLastDigit = workNum % 10;
                if (numLastDigit % 2 != 0) { result += numLastDigit; }
                workNum /= 10;
            }
            return result;
        }


        static int getMultipleOfEvensAndOdds(int a)
        {
            return getSumOfOddDigits(a) * getSumOfEvenDigits(a);
        }

    }
}
