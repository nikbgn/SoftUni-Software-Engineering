using System;
using System.Collections.Generic;
using System.Text;

namespace _01.GenericBoxofString
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
