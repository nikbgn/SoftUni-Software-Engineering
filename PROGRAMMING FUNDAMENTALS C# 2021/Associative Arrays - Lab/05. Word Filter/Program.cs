using System;
using System.Linq;

namespace _05._Word_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            //LINQ Excercise

            string[] wordsArray = Console.ReadLine().Split().Where(word => word.Length % 2 == 0).ToArray();
            foreach (string word in wordsArray)
            {
                Console.WriteLine(word);
            }
        }
    }
}
