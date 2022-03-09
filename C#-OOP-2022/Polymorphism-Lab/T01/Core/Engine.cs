namespace Operations
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
            MathOperations math = new MathOperations();
            //Test
            Console.WriteLine(math.Add(5,5));
        }

    }
}
