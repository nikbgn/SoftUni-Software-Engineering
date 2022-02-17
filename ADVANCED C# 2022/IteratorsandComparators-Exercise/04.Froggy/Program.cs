using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _04.Froggy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> elems = Console.ReadLine().Split(", ").Select(int.Parse).ToList();
            Lake lake = new Lake(elems);
            Console.WriteLine(string.Join(", ",lake));
        }


        class Lake : IEnumerable<int>
        {
            private List<int> stones;

            public Lake(List<int> elems)
            {
                this.stones = elems;
            }

            public IEnumerator<int> GetEnumerator()
            {
                for (int i = 0; i < stones.Count ; i++)
                {
                    if (i%2 == 0)
                    {
                        yield return stones[i];
                    }
                }
                
                for (int i = stones.Count - 1; i >= 0; i--)
                {
                    if (i % 2 != 0)
                    {
                        yield return stones[i];
                    }
                }
                

            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }


        
    }
}
