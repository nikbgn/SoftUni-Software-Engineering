using System;
using System.Collections.Generic;
using System.Text;

namespace _04.PizzaCalories
{
    public class Topping
    {
        private string topping;
        private int weight;
        private readonly Dictionary<string, double> modifiers =
            new Dictionary<string, double>
            {
                {"meat",1.2 },
                { "veggies", 0.8},
                { "cheese", 1.1},
                { "sauce", 0.9},
            };



        public Topping(int weight, string topping)
        {
            this.ToppingType = topping;
            this.Weight = weight;
        }



        public string ToppingType
        {
            get { return topping; }
            private set
            {
                if (!modifiers.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                topping = value;
            }
        }



        public int Weight
        {
            get { return weight; }
            private set 
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{ToppingType} {ExceptionMessages.ToppingWeightError}");
                }
                weight = value; 
            }
        }

        public double Calories
            => 2
            * Weight
            * modifiers[ToppingType.ToLower()];

    }
}
