using System;
using System.Linq;
using System.Text;

namespace _01._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordGiven = Console.ReadLine();
            

            while (wordGiven != "end")
            {
                Console.WriteLine($"{wordGiven} = {stringReverser(wordGiven)}");
                wordGiven = Console.ReadLine();
            }

        }


        public static string stringReverser(string text)
        {
            string result = string.Empty;
            for (int i = text.Length-1; i >= 0 ; i--)
            {
                result += text[i];
            }
            return result;
        }
    }
}
