using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{

    //Contracts -> Car interfaces
    public class Tesla : ICar, IElectricCar
    {
        private string model;
        private string color;
        private int battery;
        public Tesla(string model, string color, int battery)
        {
            Model = model;
            Color = color;
            Battery = battery;
        }

        
        public string Model { get => this.model;  set => this.model = value; }
        public string Color { get => this.color;  set => this.color = value; }
        public int Battery { get => this.battery; set => this.battery = value; }

        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{color} Tesla {model} with {battery} Batteries");
            sb.AppendLine(Start());
            sb.AppendLine(Stop());
            return sb.ToString().TrimEnd();
        }
    }
}
