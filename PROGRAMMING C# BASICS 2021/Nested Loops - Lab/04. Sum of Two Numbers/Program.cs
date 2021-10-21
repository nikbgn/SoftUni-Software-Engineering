using System;

namespace _04._Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int combinationNumber = 0;
            bool isFound = false;

            for (int i = firstNum; i <= secondNum; i++)
            {
                for (int j = firstNum; j <= secondNum; j++)
                {
                    combinationNumber++;
                    if (i + j == magicNumber) { Console.WriteLine($"Combination N:{combinationNumber} ({i} + {j} = {magicNumber})"); isFound = true; break; }
                    
                }
                if (isFound) { break; }
            }

            if (!isFound)
            {
                Console.WriteLine($"{combinationNumber} combinations - neither equals {magicNumber}");
            }


        }
    }
}
