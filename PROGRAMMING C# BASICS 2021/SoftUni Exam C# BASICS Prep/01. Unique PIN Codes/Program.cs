using System;

namespace _01._Unique_PIN_Codes
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstDigit = int.Parse(Console.ReadLine());
            int secondDigit = int.Parse(Console.ReadLine());
            int thirdDigit = int.Parse(Console.ReadLine());

            

            for (int firstNum = 2; firstNum <= firstDigit; firstNum++)
            {
                
                for (int secondNum = 2; secondNum <= secondDigit; secondNum++)
                {
                    for (int thirdNum = 2; thirdNum <= thirdDigit; thirdNum++)
                    {
                        if (firstNum % 2 == 0 && thirdNum % 2 == 0)
                        {
                            if (secondNum == 2 || secondNum == 3 || secondNum == 5 || secondNum == 7)
                            {
                                Console.WriteLine($"{firstNum} {secondNum} {thirdNum}");
                            }
                            
                        }
                    }
                }
            }

        }
    }
}
