using System;
using System.Collections.Generic;
using System.Text;

namespace _07.Tuple
{
    class CustomTuple<T1, T2>
    {
        private T1 item1;
        private T2 item2;

        public CustomTuple(T1 i1, T2 i2)
        {
            this.Item1 = i1;
            this.Item2 = i2;
        }

        public T1 Item1
        {
            get => item1;
            set { this.item1 = value; }
        }

        public T2 Item2
        {
            get => item2;
            set { this.item2 = value; }
        }

        public override string ToString() => $"{item1} -> {item2}";
    }
}
