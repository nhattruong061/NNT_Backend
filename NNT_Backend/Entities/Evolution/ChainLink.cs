using NNT_Backend.Entities.Pokemon.PokemonSpecies;
using System.Collections.Generic;

namespace NNT_Backend.Entities.Evolution
{
    public class ChainLink
    {
        public bool is_baby { get; set; }
        public PokemonSpecies species { get; set; }
        public IList<EvolutionDetail> evolution_details { get; set; }
        public IList<ChainLink> evolves_to { get; set; }
    }
}
