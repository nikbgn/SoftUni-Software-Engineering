using System;

namespace _04._Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int charCount = int.Parse(Console.ReadLine());
            int result = 0;


            while (charCount > 0)
            {
                char charInput = char.Parse(Console.ReadLine());
                result += charInput;
                charCount -= 1;
            }

            Console.WriteLine($"The sum equals: {result}");
        }
    }
}
