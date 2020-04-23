using NNT_Backend.Entities.Contests;
using System;
using System.Collections.Generic;

namespace NNT_Backend.Entities.Moves
{
    public class Move
    {
        public int id { get; set; }
        public string name { get; set; }
        public int accuracy { get; set; }
        public int effect_chance { get; set; }
        public int pp { get; set; }
        public int priority { get; set; }
        public int power { get; set; }
        public ContestComboSets contest_combos { get; set; }
        public ContestType contest_type { get; set; }
        public ContestEffect contest_effect { get; set; }
        public MoveDamageClass damage_class { get; set; }
        public IList<VerboseEffect> effect_entries { get; set; }
        public IList<AbilityEffectChange> effect_changes { get; set; }
        public Generation generation { get; set; }
        public MoveMetaData meta { get; set; }
        public MachineVersionDetail machines { get; set; }
        public IList<Name> names { get; set; }
        public IList<PastMoveStatValues> past_values { get; set; }
        public IList<MoveStatChange> stat_changes { get; set; }
        public SuperContestEffect super_contest_effect { get; set; }
        public MoveTarget target { get; set; }
        public Type type { get; set; }
        public IList<MoveFlavorText> flavor_text_entries { get; set; }
    }
}
