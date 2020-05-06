using System.Collections.Generic;

namespace NNT_Backend.Entities.Pokemon
{
    public class Gender
    {
        public int id { get; set; }
        public string name { get; set; }
        public IList<PokemonSpeciesGender> pokemon_species_details { get; set; }
        public IList<PokemonSpecies.PokemonSpecies> required_for_evolution { get; set; }
    }
}
