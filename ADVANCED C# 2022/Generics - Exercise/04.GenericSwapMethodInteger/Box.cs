using System;
using System.Collections.Generic;
using System.Text;

namespace _04.GenericSwapMethodInteger
{
    public class Box<T>
    {

        public Box()
        {
            this.Items = new List<T>();
        }
        public List<T> Items { get; set; }

        public void Swap(int idx1, int idx2) 
            => (Items[idx1], Items[idx2]) = (Items[idx2], Items[idx1]);

       
       


    }
}
