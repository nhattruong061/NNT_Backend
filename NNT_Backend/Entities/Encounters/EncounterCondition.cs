using NNT_Backend.Entities.Utility.CommonModels;
using System.Collections.Generic;

namespace NNT_Backend.Entities.Encounters
{
    public class EncounterCondition
    {
        public int id { get; set; }
        public string name { get; set; }
        public IList<EncounterConditionValue> values { get; set; }
        public IList<Name> names { get; set; }
    }
}
