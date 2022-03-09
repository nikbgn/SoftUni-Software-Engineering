namespace Shapes
{
    using System;
    public class Engine
    {
        public Engine()
        {

        }

        public void Run()
        {
            try
            {
                Shape circle = new Circle(1);
                Shape rect = new Rectangle(0, 0);
                Console.WriteLine(circle.CalculateArea());
                Console.WriteLine(circle.CalculatePerimeter());
                Console.WriteLine(rect.CalculateArea());
                Console.WriteLine(rect.CalculatePerimeter());
                Console.WriteLine(circle.Draw());
                Console.WriteLine(rect.Draw());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
                 
        }
    }
}
