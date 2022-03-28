using Gym.Models.Athletes.Contracts;
using Gym.Models.Equipment.Contracts;
using Gym.Models.Gyms.Contracts;
using Gym.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gym.Models.Gyms
{
    public abstract class Gym : IGym
    {
        private string name;
        private int capacity;
        private double equipmentWeight;
        private ICollection<IEquipment> equipment;
        private ICollection<IAthlete> athletes;
        protected Gym(string name, int capacity)
        {
            this.Name = name;
            this.capacity = capacity;
            this.equipment = new List<IEquipment>();
            this.athletes = new List<IAthlete>();
        }

        public string Name
        {
            get => this.name;
            set
            {
                if (string.IsNullOrEmpty(value)) throw new ArgumentException(ExceptionMessages.InvalidGymName);
                this.name = value;
            }

        }

        public int Capacity => this.capacity;

        public double EquipmentWeight => this.equipment.Sum(x => x.Weight);

        public ICollection<IEquipment> Equipment => this.equipment;

        public ICollection<IAthlete> Athletes => this.athletes;

        public void AddAthlete(IAthlete athlete)
        {
            if(Athletes.Count + 1 > Capacity)
            {
                throw new InvalidOperationException(ExceptionMessages.NotEnoughSize);
            }
            this.athletes.Add(athlete);
        }

        public void AddEquipment(IEquipment equipment) => this.equipment.Add(equipment);

        public void Exercise()
        {
            foreach (var athlete in Athletes)
            {
                athlete.Exercise();
            }
        }

        public string GymInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Name} is a {typeof(Gym).Name}");
            if (this.athletes.Count == 0)
            {
                sb.AppendLine("No athletes");
            }
            else
            {
                sb.AppendLine($"Athletes: {string.Join(", ", Athletes.Select(x => x.FullName))}");
            }
            sb.AppendLine($"Equipment total count: {Equipment.Count} ");
            sb.AppendLine($"Equipment total weight: {EquipmentWeight:f2} grams.");
            return sb.ToString().Trim();
        }

        public bool RemoveAthlete(IAthlete athlete) => this.athletes.Remove(athlete);

    }
}
