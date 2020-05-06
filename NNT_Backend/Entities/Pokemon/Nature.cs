using NNT_Backend.Entities.Berries;
using NNT_Backend.Entities.Utility.CommonModels;
using System.Collections.Generic;

namespace NNT_Backend.Entities.Pokemon
{
    public class Nature
    {
        public int id { get; set; }
        public string name { get; set; }
        public Stat decreased_stat { get; set; }
        public Stat increased_stat { get; set; }
        public BerryFlavor likes_flavor { get; set; }
        public BerryFlavor hates_flavor { get; set; }
        public IList<NatureStatChange> pokeathlon_stat_changes { get; set; }
        public IList<MoveBattleStylePreference> move_battle_style_preferences { get; set; }
        public IList<Name> names { get; set; }
    }
}
