using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Trainer
    {
        public string Name { get; set; }
        public int Badges { get; set; }
        public List<Pokemon> Pokemons { get; set; }

        public void CheckForElement(string command)
        {
            int hasPokemonWithElement = Pokemons.Where(x => x.Element == command).Count();
            if (hasPokemonWithElement > 0) Badges += 1;
            else
            {
                Pokemons.Select(x => x.Health -= 10).ToList();
                Pokemons.RemoveAll(x => x.Health <= 0);
            }
        }
    }
}
