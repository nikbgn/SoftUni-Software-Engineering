using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person t = new Person();
            Person t2 = new Person(10);
            Person t3 = new Person("Niki", 19);
        }
    }
}
