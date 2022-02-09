using System;
using System.Collections.Generic;
using System.Text;

namespace _08.Threeuple
{
    class CustomThreeuple<T1, T2, T3>
    {
        private T1 item1;
        private T2 item2;
        private T3 item3;

        public CustomThreeuple(T1 i1, T2 i2, T3 i3)
        {
            this.Item1 = i1;
            this.Item2 = i2;
            this.Item3 = i3;
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

        public T3 Item3
        {
            get => item3;
            set { this.item3 = value; }
        }

        public override string ToString() => $"{item1} -> {item2} -> {item3}";
    }
}
