using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();

            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();

            while (input[0] != "Tournament")
            {
                string trainerName = input[0];
                string pokemonName = input[1];
                string pokemonElement = input[2];
                int pokemonHealth = int.Parse(input[3]);

                if (!trainers.ContainsKey(trainerName))
                {
                    trainers.Add(trainerName, new Trainer()
                    {
                        Name = trainerName,
                        Badges = 0,
                        Pokemons = new List<Pokemon>()
                    });
                }

                trainers[trainerName].Pokemons.Add(new Pokemon()
                {
                    Name = pokemonName,
                    Element = pokemonElement,
                    Health = pokemonHealth
                });
                input = Console.ReadLine().Split();
            }

            var command = Console.ReadLine();
            while (command != "End")
            {
                foreach (var trainer in trainers)
                {
                    trainer.Value.CheckForElement(command);
                }
                command = Console.ReadLine();
            }

            foreach (var trainer in trainers.OrderByDescending(x => x.Value.Badges))
            {
                Console.WriteLine($"{trainer.Value.Name} {trainer.Value.Badges} {trainer.Value.Pokemons.Count}");
            }
        }
    }
}
