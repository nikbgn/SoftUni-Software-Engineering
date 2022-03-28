using Gym.Core.Contracts;
using Gym.Models.Athletes;
using Gym.Models.Athletes.Contracts;
using Gym.Models.Equipment;
using Gym.Models.Equipment.Contracts;
using Gym.Models.Gyms;
using Gym.Models.Gyms.Contracts;
using Gym.Repositories;
using Gym.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gym.Core
{
    public class Controller : IController
    {
        private EquipmentRepository equipmentRepository;
        private List<IGym> gyms;

        public Controller()
        {
            this.gyms = new List<IGym>();
            this.equipmentRepository = new EquipmentRepository();
        }

        public string AddAthlete(string gymName, string athleteType, string athleteName, string motivation, int numberOfMedals)
        {
            IAthlete athlete;
            
            IGym gym = this.gyms.FirstOrDefault(x=>x.Name == gymName);
            //IGym g = new BoxingGym("a'");///
            //Boxer Weightlifter
            if(athleteType == "Boxer")
            {
                if(gym.GetType().Name != "BoxingGym")
                {
                    return "The gym is not appropriate.";
                }
                athlete = new Boxer(athleteName,motivation,numberOfMedals);
                gym.AddAthlete(athlete);
                
            }
            else if (athleteType == "Weightlifter")
            {
                if (gym.GetType().Name != "WeightliftingGym")
                {
                    return "The gym is not appropriate.";
                }
                
                athlete = new Weightlifter(athleteName, motivation, numberOfMedals);
                gym.AddAthlete(athlete);

            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidAthleteType);
            }
            return $"Successfully added {athleteType} to {gymName}.";
        }



        public string AddEquipment(string equipmentType)
        {
            IEquipment equipment;
            if(equipmentType == "BoxingGloves")
            {
                equipment = new BoxingGloves();
                this.equipmentRepository.Add(equipment);
            }
            else if (equipmentType == "Kettlebell")
            {
                equipment = new Kettlebell();
                this.equipmentRepository.Add(equipment);
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidEquipmentType);
            }
            return $"Successfully added {equipmentType}.";
        }

        public string AddGym(string gymType, string gymName)
        {
            IGym gym;
            if(gymType == "BoxingGym")
            {
                gym = new BoxingGym(gymName);
                this.gyms.Add(gym);
            }
            else if (gymType == "WeightliftingGym")
            {
                gym = new WeightliftingGym(gymName);
                this.gyms.Add(gym);
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidGymType);
            }
            return $"Successfully added {gymType}.";
        }

        public string EquipmentWeight(string gymName)
        {
            IGym gym = this.gyms.FirstOrDefault(x => x.Name == gymName);
            double value = gym.EquipmentWeight;
            return $"The total weight of the equipment in the gym {gymName} is {value:F2} grams.";
        }

        public string InsertEquipment(string gymName, string equipmentType)
        {

            IEquipment equipment = this.equipmentRepository.FindByType(equipmentType);
            if (equipment == null) throw new InvalidOperationException(string.Format(ExceptionMessages.InexistentEquipment,equipmentType));

            IGym gym = this.gyms.FirstOrDefault(x => x.Name == gymName); //it will always exist!
            gym.AddEquipment(equipment);
            this.equipmentRepository.Remove(equipment);

            return $"Successfully added {equipmentType} to {gymName}.";
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var gym in this.gyms)
            {
                sb.AppendLine(gym.GymInfo());
            }
            return sb.ToString().Trim();
        }

        public string TrainAthletes(string gymName)
        {
            IGym gym = this.gyms.FirstOrDefault(x => x.Name == gymName);
            foreach (var athlete in gym.Athletes)
            {
                athlete.Exercise();
            }
            return $"Exercise athletes: {gym.Athletes.Count}.";
        }
    }
}
