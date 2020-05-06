using NNT_Backend.Entities.Encounters;
using System.Collections.Generic;

namespace NNT_Backend.Entities.Locations
{
    public class EncounterMethodRate
    {
        public EncounterMethod encounter_method { get; set; }
        public IList<EncounterVersionDetails> version_details { get; set; }
    }
}
