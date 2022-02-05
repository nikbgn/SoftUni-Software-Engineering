using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOfT
{
    public class Box<T>
    {

        private List<T> internalList = new List<T>();


        public void Add(T element)
        {
            internalList.Add(element);
        }

        public T Remove()
        {
            T itemRemoved = internalList[^1];
            internalList.RemoveAt(internalList.Count - 1);
            return itemRemoved;
        }

        public int Count => internalList.Count;

    }
}
