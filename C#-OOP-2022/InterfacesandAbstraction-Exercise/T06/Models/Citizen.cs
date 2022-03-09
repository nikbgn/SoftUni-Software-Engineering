using System;
using System.Collections.Generic;
using System.Text;

namespace T06
{
    public class Citizen : IBuyer
    {
        private int buyFoodAmount = 10;

        public Citizen(string name, int age, string id, string birthDate)
        {
            Name = name;
            Age = age;
            Id = id;
            BirthDate = birthDate;
            Food = 0;
        }

        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Id { get; private set; }
        public string BirthDate { get; private set; }

        public int Food { get; private set; }

        public void BuyFood() => Food += buyFoodAmount;
    }
}
