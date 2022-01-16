using System;
using System.Collections.Generic;
using System.Text;

namespace _09._Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfOperations = int.Parse(Console.ReadLine());
            StringBuilder text = new StringBuilder();
            Stack<string> undos = new Stack<string>();

            for (int i = 0; i < numOfOperations; i++)
            {
                string[] command = Console.ReadLine().Split();
                int token = int.Parse(command[0]);
                switch (token)
                {
                    case 1:
                        string someString = command[1];
                        undos.Push(text.ToString());
                        text.Append(someString);
                        break;
                    case 2:
                        int count = int.Parse(command[1]);
                        undos.Push(text.ToString());
                        text.Remove(text.Length - count, count);
                        break;
                    case 3:
                        int index = int.Parse(command[1]);
                        Console.WriteLine(text[index-1]);
                        break;
                    case 4:
                        text.Clear();
                        text = text.Append(undos.Pop());
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
