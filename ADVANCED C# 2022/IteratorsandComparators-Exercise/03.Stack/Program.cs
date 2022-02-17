using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _03.Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomStack<int> stack = new CustomStack<int>();
            while (true)
            {
                var cmd = Console.ReadLine();
                if (cmd.Contains("END"))
                {
                    foreach (var item in stack.Reverse())
                    {
                        Console.WriteLine(item);
                    }
                    foreach (var item in stack.Reverse())
                    {
                        Console.WriteLine(item);
                    }
                    break;
                }
                else if(cmd.Contains("Push"))
                {
                    List<int> elems = cmd
                        .Split(new string[] {"Push",","," "}, StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToList();

                    stack.Push(elems);
                        
                }
                else if(cmd.Contains("Pop"))
                {
                    stack.Pop();
                }

            }
        }



        class CustomStack<T> : IEnumerable<T>
        {

            private List<T> items;

            public CustomStack()
            {
                this.items = new List<T>();
            }

            public void Push(List<T> elements) 
            {
                foreach (var item in elements)
                {
                    items.Add(item);
                }

            }

            public void Pop()
            {
                if(!(items.Count - 1 < 0))
                {
                    items.RemoveAt(items.Count - 1);
                }
                else
                {
                    Console.WriteLine("No elements");
                }

            }

            public IEnumerator<T> GetEnumerator()
            {
                foreach (var item in items)
                {
                    yield return item;
                }
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }


    }
}
