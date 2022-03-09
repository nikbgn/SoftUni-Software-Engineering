namespace Shapes
{
    using System;
    public class Circle : Shape
    {
        private double radius;
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius
        {
            get => this.radius;
            private set
            {
                if(value <= 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidRadius);
                }
                radius = value;
            }
        }

        public override double CalculateArea() => Math.PI * Math.Pow(radius,2);

        //⦁	CalculatePerimeter
        public override double CalculatePerimeter() => 2 * Math.PI * radius;


        public override string Draw() => base.Draw() + this.GetType().Name;
    }
}
