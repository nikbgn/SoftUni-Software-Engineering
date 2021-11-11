using System;

namespace _03._Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordToRemove = Console.ReadLine();
            string bigWord = Console.ReadLine();

            int index = bigWord.IndexOf(wordToRemove);

            while (index >= 0)
            {
                bigWord = bigWord.Remove(index,wordToRemove.Length);
                index = bigWord.IndexOf(wordToRemove);
            }

            Console.WriteLine(bigWord);

        }
    }
}
