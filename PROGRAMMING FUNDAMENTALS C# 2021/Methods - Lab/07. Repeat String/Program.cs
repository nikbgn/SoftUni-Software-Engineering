using System;

namespace _07._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            int timesToRepeat = int.Parse(Console.ReadLine());
            Console.WriteLine(repeatString(userInput,timesToRepeat));
        }


        static string repeatString(string a, int b)
        {
            string result = string.Empty;

            for (int i = 0; i < b; i++)
            {
                result += a;
            }

            return result;
        }


    }
}
