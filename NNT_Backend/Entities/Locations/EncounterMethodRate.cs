using System.Collections.Generic;

namespace NNT_Backend.Entities.Locations
{
    public class EncounterMethodRate
    {
        public EncounterMethod encounter_method { get; set; }
        public IList<EncounterVersionDetail> version_details { get; set; }
    }
}
