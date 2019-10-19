using System;
using System.Collections.Generic;
using System.Linq;

namespace Defclass_tesk11
{
    public class StartUp
    {
        public static void Main()
        {
            List<Trainer> trainers = new List<Trainer>();
            string command;
            while ((command = Console.ReadLine())!="Tournament")
            {
                //< TrainerName > < PokemonName > < PokemonElement > < PokemonHealth >
                List<string> data = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                string trainerName = data[0];
                Pokemon current = new Pokemon(data[1], data[2], int.Parse(data[3]));
                if (!trainers.Any(x=>x.Name==trainerName))
                {
                    trainers.Add(new Trainer(trainerName));
                    trainers.First(x => x.Name == trainerName).Pokemons.Add(current);
                }
                else
                {
                    trainers.First(x => x.Name == trainerName).Pokemons.Add(current);
                }
            }
            string command2;
            while ((command2=Console.ReadLine())!="End")
            {
                if (trainers.Any(x => x.Pokemons.Any(p => p.Element == command2)))
                {
                    var name = trainers.First(x => x.Pokemons.Any(p => p.Element == command2)).Name;
                    trainers.First(x => x.Pokemons.Any(p => p.Element == command2)).NumberOfBadges += 1;
                }
                else
                {
                    foreach (var trainer in trainers)
                    {
                        foreach (var pokemon in trainer.Pokemons)
                        {
                            pokemon.Health -= 10;
                            if (pokemon.Health<0)
                            {
                                trainer.Pokemons.Remove(pokemon);
                            }
                        }
                    }
                }
            }
            //print all of the trainers sorted by the amount of badges they have in descending order
            //(if two trainers have the same amount of badges, they should be sorted by order of appearance in the input)
            //in the format “< TrainerName > < Badges > < NumberOfPokemon >”.
            var result = trainers.GroupBy(x => x.Name)
                .Select(x => new { TrainersName = x.Key, Badges = x.OrderByDescending(t=>t.NumberOfBadges),NumberOfPokemons = x.OrderBy(p=>p.Pokemons.Count)})
                .ToList();
            foreach (var group in result)
            {
                Console.WriteLine($"{group.TrainersName} {group.Badges} {group.NumberOfPokemons}");
            }

        }
    }
}
