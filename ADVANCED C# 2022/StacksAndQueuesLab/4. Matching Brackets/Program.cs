using System;
using System.Collections.Generic;

namespace _4._Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> positions = new Stack<int>();
            string userInput = Console.ReadLine();
            for (int i = 0; i < userInput.Length; i++)
            {
                if(userInput[i] == '(')
                {
                    positions.Push(i);
                }
                else if (userInput[i] == ')')
                {
                    int start = positions.Pop();
                    Console.WriteLine(userInput.Substring(start, i-start+1));
                }
            }
        }
    }
}
