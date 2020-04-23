using NNT_Backend.Entities.Utility.CommonModels;
using System.Collections.Generic;

namespace NNT_Backend.Entities.Locations
{
    public class LocationArea
    {
        public int id { get; set; }
        public string name { get; set; }
        public int game_index { get; set; }
        public IList<EncounterMethodRate> encounter_method_rates { get; set; }
        public Location location { get; set; }
        public IList<Name> names { get; set; }
        public IList<PokemonEncounter> pokemon_encounters { get; set; }
    }
}
