using System;

namespace _05._Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string lettersText = string.Empty;
            string digitsText = string.Empty;
            string otherSymbolsText = string.Empty;

            foreach (var character in text)
            {
                if (char.IsLetter(character))
                {
                    lettersText += character;
                }
                else if (char.IsDigit(character))
                {
                    digitsText += character;
                }
                else
                {
                    otherSymbolsText += character;
                }
            }

            Console.WriteLine(digitsText);
            Console.WriteLine(lettersText);
            Console.WriteLine(otherSymbolsText);

        }
    }
}
