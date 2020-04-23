using NNT_Backend.Entities.Moves;

namespace NNT_Backend.Entities.Pokemon
{
    public class MoveBattleStylePreference
    {
        public int low_hp_preference { get; set; }
        public int high_hp_preference { get; set; }
        public MoveBattleStyle move_battle_style { get; set; }
    }
}
