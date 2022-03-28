using Gym.Models.Athletes.Contracts;
using Gym.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gym.Models.Athletes
{
    public abstract class Athlete : IAthlete
    {

        private string fullName;
        private string motivation;
        private int stamina;
        private int numberOfMedals;
        protected Athlete(string fullName, string motivation, int numberOfMedals, int stamina)
        {
            this.FullName = fullName;
            this.Motivation = motivation;
            this.Stamina = stamina;
            this.NumberOfMedals = numberOfMedals;
        }
        //OK
        public string FullName
        {
            get => this.fullName;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidAthleteName);
                }
                this.fullName = value;
            }
        }
        //OK
        public string Motivation
        {
            get => this.motivation;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidAthleteMotivation);
                }
                this.motivation = value;
            }
        }

        public int Stamina
        {
            get => this.stamina;
            set { this.stamina = value; }
        }

        public int NumberOfMedals
        {
            get => this.numberOfMedals;
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidAthleteMedals);
                }
                this.numberOfMedals = value;
            }
        }

        public virtual void Exercise()
        {

        }
    }
}
