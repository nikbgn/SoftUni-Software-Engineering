using System;
using System.Collections.Generic;

namespace _08._Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var openingParenthesis = new Stack<char>();
            bool balanced = true;
            foreach (char character in input)
            {
                if (character == '(' ||
                    character == '[' ||
                    character == '{')
                {
                    openingParenthesis.Push(character);
                    continue;
                }

                if (openingParenthesis.Count == 0)
                {
                    balanced = false;
                    break;
                }

                if (character == ')' && openingParenthesis.Peek() == '(')
                {
                    openingParenthesis.Pop();
                }
                else if (character == ']' && openingParenthesis.Peek() == '[')
                {
                    openingParenthesis.Pop();
                }
                else if (character == '}' && openingParenthesis.Peek() == '{')
                {
                    openingParenthesis.Pop();
                }
                else
                {
                    balanced = false;
                    break;
                }
            }


            if (!balanced || openingParenthesis.Count > 0) Console.WriteLine("NO");
            else Console.WriteLine("YES");


            
        }
    }
}
