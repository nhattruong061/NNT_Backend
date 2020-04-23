using NNT_Backend.Entities.Games;
using System.Collections.Generic;

namespace NNT_Backend.Entities.Pokemon.Ability
{
    public class Ability
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool is_main_series { get; set; }
        public Generation generation { get; set; }
        public IList<Name> names { get; set; }
        public IList<VerboseEffect> effect_entries { get; set; }
        public IList<AbilityEffectChange> effect_changes { get; set; }
        public IList<AbilityFlavorText> flavor_text_entries { get; set; }
        public IList<AbilityPokemon> pokemon { get; set; }
    }
}
