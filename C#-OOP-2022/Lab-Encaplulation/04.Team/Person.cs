using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private int salary;
        public Person(string firstName, string lastName, int age, decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Salary = salary;
        }

        public string FirstName
        {
            get => this.firstName;
            private set
            {
                if (value.Length >= 3)
                {
                    this.firstName = value;
                }
                else
                {
                    throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
                }

            }
        }
        public string LastName
        {
            get => this.lastName;
            private set
            {
                if (value.Length >= 3)
                {
                    this.firstName = value;
                }
                else
                {
                    throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
                }

            }
        }
        public int Age
        {
            get => this.age;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Age cannot be zero or a negative integer!");
                }
                this.age = value;

            }
        }
        public decimal Salary
        {
            get => this.salary;
            set
            {
                if(value < 650)
                {
                    throw new ArgumentException("Salary cannot be less than 650 leva!");
                }
                
            }
        }


        public void IncreaseSalary(decimal percentage)
        {
            if (Age < 30)
            {
                Salary += Salary * percentage / 200M;
            }
            else
            {
                Salary += Salary * percentage / 100M;
            }
        }
        public override string ToString() => $"{FirstName} {LastName} receives {Salary:f2} leva.";
    }
}
