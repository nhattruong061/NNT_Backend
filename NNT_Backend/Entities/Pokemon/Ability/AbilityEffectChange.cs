using NNT_Backend.Entities.Evolution;
using System.Collections.Generic;

namespace NNT_Backend.Entities.Pokemon.Ability
{
    public class AbilityEffectChange
    {
        public IList<Effect> effect_entries { get; set; }
        public VersionGroup version_group { get; set; }
    }
}
