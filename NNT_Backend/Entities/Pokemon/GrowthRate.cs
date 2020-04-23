using System.Collections.Generic;

namespace NNT_Backend.Entities.Pokemon
{
    public class GrowthRate
    {
        public int id { get; set; }
        public string name { get; set; }
        public string formula { get; set; }
        public IList<Description> descriptions { get; set; }
        public IList<GrowthRateExperienceLevel> levels { get; set; }
        public IList<PokemonSpecies> pokemon_species { get; set; }
    }
}
