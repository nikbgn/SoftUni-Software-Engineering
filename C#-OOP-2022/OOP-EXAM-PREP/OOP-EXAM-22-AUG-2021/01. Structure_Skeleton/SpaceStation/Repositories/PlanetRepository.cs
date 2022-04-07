using SpaceStation.Models.Planets.Contracts;
using SpaceStation.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceStation.Repositories
{
    public class PlanetRepository : IRepository<IPlanet>
    {
        private readonly List<IPlanet> models;
        public PlanetRepository()
        {
            this.models = new List<IPlanet>();
        }
        public IReadOnlyCollection<IPlanet> Models => this.models.AsReadOnly();


        public void Add(IPlanet model) => this.models.Add(model);

        public IPlanet FindByName(string name)
        {
            IPlanet findByName = this.models.FirstOrDefault(x => x.Name == name);
            return findByName;
        }

        public bool Remove(IPlanet model) => this.models.Remove(model);
    }
}
