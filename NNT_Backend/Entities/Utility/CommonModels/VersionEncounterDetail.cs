using System;
using System.Collections.Generic;

namespace NNT_Backend.Entities.Utility.CommonModels
{
    public class VersionEncounterDetail
    {
        public Version version { get; set; }
        public int max_change { get; set; }
        public IList<Encounter> encounter_details { get; set; }
    }
}
