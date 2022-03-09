namespace Animals
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Engine
    {
        public Engine()
        {

        }

        public void Run()
        {
            Animal cat = new Cat("Peter", "Whiskas");
            Animal dog = new Dog("George", "Meat");

            Console.WriteLine(cat.ExplainSelf());
            Console.WriteLine(dog.ExplainSelf());

        }
    }
}
