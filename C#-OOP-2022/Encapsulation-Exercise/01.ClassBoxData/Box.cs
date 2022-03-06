using System;
using System.Collections.Generic;
using System.Text;

namespace _01.ClassBoxData
{
    public class Box
    {

        private double length;
        private double width;
        private double height;

        public Box(double l, double w, double h)
        {
            Length = l;
            Width = w;
            Height = h;
        }



        public double Length
        {
            get => this.length;
            private set
            {
                if (value <= 0) throw new ArgumentException($"Length cannot be zero or negative.");
                else this.length = value;
            }

        }


        public double Width
        {
            get => this.width;
            private set
            {
                if (value <= 0) throw new ArgumentException($"Width cannot be zero or negative.");
                else this.width = value;
            }

        }

        public double Height
        {
            get => this.height;
            private set
            {
                if (value <= 0) throw new ArgumentException($"Height cannot be zero or negative.");
                else this.height = value;
            }

        }


        //2lw + 2lh + 2wh
        public double SurfaceArea() => 
            2 * length * width
            + 2 * length * height
            + 2 * width * height;
        //2lh + 2wh
        public double LateralSurfaceArea() =>
            2 * length * height
            + 2 * width * height;
        //lwh
        public double Volume() => length * width * height;

    }
}
