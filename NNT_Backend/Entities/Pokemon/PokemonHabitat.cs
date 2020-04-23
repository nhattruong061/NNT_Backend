using System.Collections.Generic;

namespace NNT_Backend.Entities.Pokemon
{
    public class PokemonHabitat
    {
        public int id { get; set; }
        public string name { get; set; }
        public PokemonSpecies pokemon_species { get; set; }
        public IList<Name> names { get; set; }
    }
}
