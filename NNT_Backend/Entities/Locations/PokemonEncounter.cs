using System.Collections.Generic;

namespace NNT_Backend.Entities.Locations
{
    public class PokemonEncounter
    {
        public Pokemon pokemon { get; set; }
        public IList<VersionEncounterDetail> version_details { get; set; }
    }
}
