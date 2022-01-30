﻿using System;
using System.Linq;

namespace _11.TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int asciiSum = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split();

            Func<string, int, bool> biggerOrEqualToAsciiSum = (name,sum) => name.Sum(x => x) >= sum;
            Func<string[],int,Func<string,int,bool>,string> solution = (names,xz,func) => names.Where(x => func(x,xz)).FirstOrDefault();

            var name = solution(names, asciiSum, biggerOrEqualToAsciiSum);
            Console.WriteLine(name);
        }
    }
}
