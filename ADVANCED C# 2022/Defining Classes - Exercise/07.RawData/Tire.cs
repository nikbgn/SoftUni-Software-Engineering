using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Tire
    {
        public Tire(int age, float pressure)
        {
            Age = age;
            Pressure = pressure;
        }

        public int Age { get; set; }
        public float Pressure { get; set; }

        public static Func<Car, bool> hasLowPressureTire = x =>
         {
             int count = x.Tires.Where(x => x.Pressure < 1).Count();
             return count > 1 ? true : false;
         };
    }
}
