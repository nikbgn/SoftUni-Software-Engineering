using SpaceStation.Core.Contracts;
using SpaceStation.Models.Astronauts;
using SpaceStation.Models.Astronauts.Contracts;
using SpaceStation.Models.Mission;
using SpaceStation.Models.Planets;
using SpaceStation.Models.Planets.Contracts;
using SpaceStation.Repositories;
using SpaceStation.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceStation.Core
{
    public class Controller : IController
    {
        private AstronautRepository astronautRepository;
        private PlanetRepository planetRepository;
        private int planetsExplored;
        public Controller()
        {
            this.astronautRepository = new AstronautRepository();
            this.planetRepository = new PlanetRepository();
        }

        public string AddAstronaut(string type, string astronautName)
        {
            IAstronaut astronaut = null;
            if(type == "Biologist")
            {
                astronaut = new Biologist(astronautName);
                this.astronautRepository.Add(astronaut);
            }
            else if (type == "Geodesist")
            {
                astronaut = new Geodesist(astronautName);
                this.astronautRepository.Add(astronaut);
            }
            else if (type == "Meteorologist")
            {
                astronaut = new Meteorologist(astronautName);
                this.astronautRepository.Add(astronaut);
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidAstronautType);
            }
            return $"{string.Format(OutputMessages.AstronautAdded,type,astronautName)}";
        }

        public string AddPlanet(string planetName, params string[] items)
        {
            IPlanet planet = new Planet(planetName);
            foreach (var item in items)
            {
                planet.Items.Add(item);
            }
            this.planetRepository.Add(planet);
            return $"{string.Format(OutputMessages.PlanetAdded,planetName)}";
        }

        public string ExplorePlanet(string planetName)
        {
            Mission mission = new Mission();
            IPlanet planetToExplore = this.planetRepository.FindByName(planetName);
            List<IAstronaut> astronautsForMission =
                this.astronautRepository.Models.Where(x => x.Oxygen > 60).ToList();
            if(astronautsForMission.Count == 0)
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidAstronautCount);
            }
            int initialCount = astronautsForMission.Count;
            mission.Explore(planetToExplore, astronautsForMission);
            int test = astronautsForMission.Where(x => x.Oxygen == 0).Count();
            this.planetRepository.Remove(planetToExplore);
            this.planetsExplored++;
            return $"{string.Format(OutputMessages.PlanetExplored,planetName,test)}";
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.planetsExplored} planets were explored!");
            sb.AppendLine("Astronauts info:");
            foreach (var item in this.astronautRepository.Models)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString().TrimEnd();
        }

        public string RetireAstronaut(string astronautName)
        {
            IAstronaut astronaut = this.astronautRepository.Models.FirstOrDefault(x => x.Name == astronautName);
            if(astronaut == null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.InvalidRetiredAstronaut, astronautName));
            }
            else
            {
                this.astronautRepository.Remove(astronaut);
                return $"{string.Format(OutputMessages.AstronautRetired,astronautName)}";
            }
        }
    }
}
