﻿using NNT_Backend.Entities.Utility.CommonModels;
using System.Collections.Generic;

namespace NNT_Backend.Entities.Encounters
{
    public class EncounterConditionValue
    {
        public int id { get; set; }
        public string name { get; set; }
        public EncounterCondition condition { get; set; }
        public IList<Name> names { get; set; }
    }
}
