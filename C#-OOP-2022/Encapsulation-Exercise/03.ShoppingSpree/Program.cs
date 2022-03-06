using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();
            //Extract ppl
            string[] extractPPL = Console.ReadLine()
                .Split(';',StringSplitOptions.RemoveEmptyEntries);

            //Fill people list
            foreach (var person in extractPPL)
            {
                try
                {
                    string[] currInfo = person.Split('=', StringSplitOptions.RemoveEmptyEntries);
                    string name = currInfo[0];
                    decimal money = decimal.Parse(currInfo[1]);
                    people.Add(new Person(name,money));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
            }

            string[] extractProducts = Console.ReadLine()
                .Split(';', StringSplitOptions.RemoveEmptyEntries);

            foreach (var product in extractProducts)
            {
                try
                {
                    string[] currInfo = product.Split('=', StringSplitOptions.RemoveEmptyEntries);
                    string name = currInfo[0];
                    decimal price = decimal.Parse(currInfo[1]);
                    products.Add(new Product(name, price));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
            }




            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] tokens = input.Split();
                Person person = people.FirstOrDefault(x => x.Name == tokens[0]);
                Product product = products.FirstOrDefault(x => x.Name == tokens[1]);
                person.BuyProduct(product);
                input = Console.ReadLine();
            }

            people.ForEach(x => Console.WriteLine(x.ToString()));



        }
    }
}
