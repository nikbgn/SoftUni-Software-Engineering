using System;
using System.Collections.Generic;
using System.Text;

namespace _04.PizzaCalories
{
    public class Dough
    {

        private string flourType;
        private string bakingTechnique;
        private int weight;


        private readonly Dictionary <string,double> modifiers
            = new Dictionary<string, double>
            {
                { "white",1.5},
                { "wholegrain",1.0},
                { "crispy",0.9},
                { "chewy",1.1},
                { "homemade",1.0},
            };

        public Dough(string flourType, string bakingTechnique, int weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.weight = weight;
        }



        public int Weight
        {
            get { return weight; }
            private set
            {
                if(value < 1 || value > 200)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidWeight);
                }

                weight = value;
            }
        }


        public string FlourType
        {
            get => this.flourType;
            private set
            {
                if (!modifiers.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidDoughType);
                }
                flourType = value;
            }
        }

        

        public string BakingTechnique
        {
            get => this.bakingTechnique;
            private set
            {
                if (!modifiers.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidDoughType);
                }
                bakingTechnique = value;
            }
        }

        public double Calories
            => 
            2 * 
            this.Weight * 
            modifiers[FlourType.ToLower()] * 
            modifiers[BakingTechnique.ToLower()];
    }
}
