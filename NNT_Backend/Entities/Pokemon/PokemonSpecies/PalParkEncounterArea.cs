using NNT_Backend.Entities.Locations;

namespace NNT_Backend.Entities.Pokemon.PokemonSpecies
{
    public class PalParkEncounterArea
    {
        public int base_score { get; set; }
        public int rate { get; set; }
        public PalParkArea area { get; set; }
    }
}
