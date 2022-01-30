using System;

namespace _07.PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengthFilter = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split();
            Action<string[],int> nameFilter = (nameArr,lenMax) =>
            {
                foreach (string name in nameArr)
                {
                    if (name.Length <= lenMax) Console.WriteLine(name);
                }
            };

            nameFilter(names, lengthFilter);

        }
    }
}
