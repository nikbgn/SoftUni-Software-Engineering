using System;
using System.Collections.Generic;
using System.Text;

namespace _02.GenericBoxofInteger
{
    public class Box<T>
    {
        private T valueHolder;

        public Box(T value)
        {
            this.valueHolder = value;
        }

        public override string ToString() => $"{this.valueHolder.GetType()}: {this.valueHolder}";
    }
}
