using System.Collections.Generic;

namespace NNT_Backend.Entities.Evolution
{
    public class EvolutionTrigger
    {
        public int id { get; set; }
        public string name { get; set; }
        public IList<Name> names { get; set; }
        public IList<PokemonSpecies> pokemon_species { get; set; }
    }
}
