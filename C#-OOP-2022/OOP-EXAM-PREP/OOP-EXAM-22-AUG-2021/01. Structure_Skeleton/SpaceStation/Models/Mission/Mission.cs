using SpaceStation.Models.Astronauts.Contracts;
using SpaceStation.Models.Mission.Contracts;
using SpaceStation.Models.Planets.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceStation.Models.Mission
{
    public class Mission : IMission
    {
        public void Explore(IPlanet planet, ICollection<IAstronaut> astronauts)
        {
            foreach (var astronaut in astronauts)
            {
                while (astronaut.CanBreath)
                {
                    var itemFound = planet.Items.FirstOrDefault();
                    if(itemFound != null)
                    {
                        astronaut.Bag.Items.Add(itemFound);
                        astronaut.Breath();
                        planet.Items.Remove(itemFound);
                    }
                    if (planet.Items.Count == 0) break;
                }
            }
        }
    }
}
