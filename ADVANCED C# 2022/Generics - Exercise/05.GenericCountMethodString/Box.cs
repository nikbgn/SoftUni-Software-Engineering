using System;
using System.Collections.Generic;
using System.Text;

namespace _05.GenericCountMethodString
{
    public class Box<T>
        where T : IComparable
    {

        public Box()
        {
            this.Items = new List<T>();
        }
        public List<T> Items { get; set; }




        public int CountBiggerThan(T item)
        {
            int result = 0;


            foreach (var elem in Items)
            {
                if(elem.CompareTo(item) > 0)
                {
                    result++;
                }
            }


            return result;
        }


        public void Swap(int idx1, int idx2) 
            => (Items[idx1], Items[idx2]) = (Items[idx2], Items[idx1]);

       
       


    }
}
