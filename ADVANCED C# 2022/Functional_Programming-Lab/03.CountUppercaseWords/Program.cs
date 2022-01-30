using System;
using System.Linq;
namespace _03.CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> WordIsUppercase = (word) => char.IsUpper(word[0]);
            string[] text = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            foreach (var word in text.Where(WordIsUppercase).ToArray())
            {
                Console.WriteLine(word);
            }
        }
    }
}
