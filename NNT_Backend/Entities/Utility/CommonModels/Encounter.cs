using NNT_Backend.Entities.Encounters;

namespace NNT_Backend.Entities.Utility.CommonModels
{
    public class Encounter
    {
        public int min_level { get; set; }
        public int max_level { get; set; }
        public EncounterConditionValue condition_values { get; set; }
        public int chance { get; set; }
        public EncounterMethod method { get; set; }
    }
}
