using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.PizzaCalories
{
    public class Pizza
    {
        private string name;
        private List<Topping> toppings;

        public Pizza(string name, Dough dough)
        {
            this.Name = name;
            this.Dough = dough;
            this.toppings = new List<Topping>();
        }



        public Dough Dough { get; private set; }

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 1 || value.Length > 15)
                {
                    throw new ArgumentException(ExceptionMessages.PizzaNameException);
                }
                this.name = value;
            }
        }

        public double Calories
            => this.Dough.Calories
            + toppings.Sum(x => x.Calories);

        public void AddTopping(Topping topping)
        {
            if (toppings.Count == 10)
            {
                throw new ArgumentException(ExceptionMessages.NumberOfToppingsError);
            }

            this.toppings.Add(topping);
        }


    }
}
