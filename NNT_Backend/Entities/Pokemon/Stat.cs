using NNT_Backend.Entities.Moves;
using System.Collections.Generic;

namespace NNT_Backend.Entities.Pokemon
{
    public class Stat
    {
        public int id { get; set; }
        public string name { get; set; }
        public int game_index { get; set; }
        public bool is_battle_only { get; set; }
        public MoveStatAffectSets affecting_moves { get; set; }
        public NatureStatAffectSets affecting_natures { get; set; }
        public IList<Characteristic> characteristics { get; set; }
        public MoveDamageClass move_damage_class { get; set; }
        public IList<Name> names { get; set; }
    }
}
