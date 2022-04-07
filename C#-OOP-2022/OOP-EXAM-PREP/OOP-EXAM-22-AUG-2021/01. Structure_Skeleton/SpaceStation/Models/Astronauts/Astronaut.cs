using SpaceStation.Models.Astronauts.Contracts;
using SpaceStation.Models.Bags;
using SpaceStation.Models.Bags.Contracts;
using SpaceStation.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SpaceStation.Models.Astronauts
{
    public abstract class Astronaut : IAstronaut
    {
        private string name;
        private double oxygen;
        private IBag bag;
        public Astronaut(string name, double oxygen)
        {
            this.Name = name;
            this.Oxygen = oxygen;
            this.bag = new Backpack();
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentNullException(ExceptionMessages.InvalidAstronautName);
                this.name = value;
            }
        }

        public double Oxygen
        {
            get => this.oxygen;
            protected set
            {
                if (value < 0) throw new ArgumentException(ExceptionMessages.InvalidOxygen);
                this.oxygen = value;
            }
        }




        public bool CanBreath
        {
            get => this.Oxygen > 0;
        }

        public IBag Bag
        {
            get => this.bag;
            private set
            {
                this.bag = value; //THIS MIGHT NEED A PUILIC SET !!!!!!!!
            }
        }

        public virtual void Breath()
        {
            this.oxygen -= 10;
            if(this.oxygen < 0)
            {
                this.Oxygen = 0;
            }
        }



        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {this.Name}");
            sb.AppendLine($"Oxygen: {this.Oxygen}");
            if(this.bag.Items.Any() == false)
            {
                sb.AppendLine("Bag items: none");
            }
            else
            {
                sb.AppendLine($"Bag items: {string.Join(", ",this.bag.Items)}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
