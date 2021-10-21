using System;

namespace _05._Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int firstElement = 1; firstElement <= n; firstElement++) //1st element
            {
                for (int secondElement = 1; secondElement <= n; secondElement++) // 2nd element
                {
                    for (char thirdElement = 'a'; thirdElement < 'a'+l; thirdElement++) //3rd element
                    {
                        for (char fourthElement = 'a'; fourthElement < 'a'+l; fourthElement++) //4th element
                        {
                            for (int fifthElement = 1; fifthElement <= n; fifthElement++)//5th element
                            {
                                if (fifthElement > firstElement && fifthElement > secondElement) { Console.Write($"{firstElement}{secondElement}{thirdElement}{fourthElement}{fifthElement} "); }
                            }
                        }
                    }
                }
            }

        }
    }
}
