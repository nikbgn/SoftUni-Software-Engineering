namespace Shapes
{
    using System;
    public class Rectangle : Shape
    {


        private double height;
        private double width;
        public Rectangle(double height, double width)
        {
            Width = width;
            Height = height;
        }

        public double Height
        {
            get => this.height;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidHeight);
                }
                this.height = value;
            }
        }
        public double Width
        {
            get => this.width;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidWidth);
                }
                this.width = value;
            }
        }


        public override double CalculateArea() => this.height * this.width;

        public override double CalculatePerimeter() => 2 * (this.width + this.height);

        public override string Draw() => base.Draw() + this.GetType().Name;

    }
}
