using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.ShoppingSpree
{
    public class Person
    {

        private string name;
        private decimal money;
        private List<Product> products;

        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
            this.products = new List<Product>();
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }

                name = value;
            }
        }

        public decimal Money
        {
            get { return money; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                this.money = value;
            }
        }


        public List<Product> Products
        {
            get { return products; }
            private set { products = value; }
        }

        public void BuyProduct(Product product)
        {
            if (money >= product.Cost)
            {
                Console.WriteLine($"{this.name} bought {product.Name}");
                products.Add(product);
                this.money -= product.Cost;
            }
            else Console.WriteLine($"{name} can't afford {product.Name}");
        }


        public override string ToString() =>
            this.products.Count > 0 ?
            $"{this.name} - {string.Join(", ", this.products.Select(x=>x.Name))}" :
            $"{this.name} - Nothing bought";
    }
}
