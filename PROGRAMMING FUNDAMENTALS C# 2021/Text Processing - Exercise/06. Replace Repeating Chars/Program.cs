using System;

namespace _06._Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string stringWithRepeatingChars = Console.ReadLine();
            char startIndex = stringWithRepeatingChars[1];

            if (startIndex != stringWithRepeatingChars[0])
            {
                Console.Write(stringWithRepeatingChars[0]);
            }

            for (int i = 1; i < stringWithRepeatingChars.Length - 1; i++)
            {
                if (startIndex != stringWithRepeatingChars[i + 1])
                {
                    Console.Write(startIndex);
                    startIndex = stringWithRepeatingChars[i + 1];
                }
                else
                {
                    startIndex = stringWithRepeatingChars[i + 1];
                }
            }

            Console.Write(stringWithRepeatingChars[^1]);


        }
    }
}
