using System;
using System.Collections.Generic;
using System.Text;

namespace GenericArrayCreator
{
    public static class ArrayCreator
    {
        public static T[] Create<T>(int count, T defaultValueFill)
        {
            var array = new T[count];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = defaultValueFill;
            }
            return array;
        }
    }
}
