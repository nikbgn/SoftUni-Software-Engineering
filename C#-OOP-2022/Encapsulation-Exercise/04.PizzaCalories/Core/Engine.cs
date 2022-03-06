using System;
using System.Collections.Generic;
using System.Text;

namespace _04.PizzaCalories
{
    public class Engine
    {


        public void Run()
        {
            string[] inputPizza = Console.ReadLine().Split();
            string name = inputPizza[1];



            string[] inputDough = Console.ReadLine().Split();
            string flourType = inputDough[1];
            string bakingTechnique = inputDough[2];
            int weight = int.Parse(inputDough[3]);

            try
            {


                Dough dough = new Dough(flourType, bakingTechnique, weight);

                Pizza pizza = new Pizza(name, dough);

                string input = Console.ReadLine();
                while (input != "END")
                {
                    string[] toppingInfo = input.Split();
                    string toppingType = toppingInfo[1];
                    int toppingWeight = int.Parse(toppingInfo[2]);
                    Topping topping = new Topping(toppingWeight, toppingType);
                    pizza.AddTopping(topping);

                    input = Console.ReadLine();
                }

                Console.WriteLine($"{pizza.Name} - {pizza.Calories:f2} Calories.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
        }

    }
}
