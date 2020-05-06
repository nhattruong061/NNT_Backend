using NNT_Backend.Entities.Utility.CommonModels;
using System.Collections.Generic;

namespace NNT_Backend.Entities.Locations
{
    public class PokemonEncounter
    {
        public Pokemon.Pokemon.Pokemon pokemon { get; set; }
        public IList<VersionEncounterDetail> version_details { get; set; }
    }
}
