using NNT_Backend.Entities.Pokemon.PokemonSpecies;
using NNT_Backend.Entities.Utility.CommonModels;
using System.Collections.Generic;

namespace NNT_Backend.Entities.Pokemon
{
    public class EggGroup
    {
        public int id { get; set; }
        public string name { get; set; }
        public IList<Name> names { get; set; }
        public PokemonSpecies.PokemonSpecies pokemon_species { get; set; }
    }
}
