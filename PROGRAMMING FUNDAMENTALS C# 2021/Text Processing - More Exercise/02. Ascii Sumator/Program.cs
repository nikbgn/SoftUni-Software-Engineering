using System;


namespace _02._Ascii_Sumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            string randomString = Console.ReadLine();
            int asciiSum = 0;
            foreach (var character in randomString)
            {
                if (character > firstChar && character < secondChar) {asciiSum += character; }
            }
            Console.WriteLine(asciiSum);
        }
    }
}
