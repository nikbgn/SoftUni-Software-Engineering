using System;

namespace _09._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            softUniProblemSolver();
            Math.Pow(2, 2);
        }

        static void softUniProblemSolver()
        {
            string valsToCompareType = Console.ReadLine();
            switch (valsToCompareType)
            {
                case "string":
                    Console.WriteLine(getMaxValue(Console.ReadLine(), Console.ReadLine()));
                    break;
                case "int":
                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine(getMaxValue(a, b)); 
                    break;
                case "char":
                    char c = char.Parse(Console.ReadLine());
                    char d = char.Parse(Console.ReadLine());
                    Console.WriteLine(getMaxValue(c, d));
                    break;
            }
        }

        static string getMaxValue(string value1, string value2)
        {
            if (value1.CompareTo(value2) > 0) { return value1; }
            return value2;
        }


        static int getMaxValue(int value1, int value2)
        {
            if (value1 > value2) { return value1; }
            return value2;
        }


        static char getMaxValue(char value1, char value2)
        {
            if (value1 > value2) { return value1; }
            return value2;
        }

    }
}
