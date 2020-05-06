using NNT_Backend.Entities.Pokemon.PokemonSpecies;

namespace NNT_Backend.Entities.Locations
{
    public class PalParkEncounterSpecies
    {
        public int base_score { get; set; }
        public int rate { get; set; }
        public PokemonSpecies pokemon_species { get; set; }
    }
}
