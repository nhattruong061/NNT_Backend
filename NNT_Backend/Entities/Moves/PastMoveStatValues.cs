using NNT_Backend.Entities.Evolution;
using NNT_Backend.Entities.Utility.CommonModels;
using System;
using System.Collections.Generic;

namespace NNT_Backend.Entities.Moves
{
    public class PastMoveStatValues
    {
        public int accuracy { get; set; }
        public int effect_chance { get; set; }
        public int power { get; set; }
        public int pp { get; set; }
        public IList<VerboseEffect> effect_entries { get; set; }
        public Type type { get; set; }
        public VersionGroup version_group { get; set; }
    }
}
