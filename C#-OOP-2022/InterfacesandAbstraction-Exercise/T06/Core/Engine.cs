using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T06
{
    public class Engine
    {
        private List<IBuyer> buyers;
        
        public Engine()
        {
            this.buyers = new List<IBuyer>();
        }

        public void Run()
        {
            int numOfPeople = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOfPeople; i++)
            {
                CreateBuyer();
            }

            string input = Console.ReadLine();
            while (input != "End")
            {
                IBuyer findBuyer = this.buyers.FirstOrDefault(x => x.Name == input);
                if (!(findBuyer == null))
                {
                    findBuyer.BuyFood();
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(buyers.Select(x=>x.Food).Sum());

        }

        private void CreateBuyer()
        {
            string[] tokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            IBuyer buyer;
            if (tokens.Length == 4)
            {
                string name = tokens[0];
                int age = int.Parse(tokens[1]);
                string id = tokens[2];
                string birthdate = tokens[3];
                buyer = new Citizen(name, age, id, birthdate);
                this.buyers.Add(buyer);
            }
            else
            {
                string name = tokens[0];
                int age = int.Parse(tokens[1]);
                string group = tokens[2];
                buyer = new Rebel(name, age, group);
                this.buyers.Add(buyer);
            }
        }
    }
}
