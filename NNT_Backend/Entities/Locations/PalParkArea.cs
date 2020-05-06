using NNT_Backend.Entities.Utility.CommonModels;
using System.Collections.Generic;

namespace NNT_Backend.Entities.Locations
{
    public class PalParkArea
    {
        public int id { get; set; }
        public string name { get; set; }
        public IList<Name> names { get; set; }
        public IList<PalParkEncounterSpecies> pokemon_encounters { get; set; }
    }
}
