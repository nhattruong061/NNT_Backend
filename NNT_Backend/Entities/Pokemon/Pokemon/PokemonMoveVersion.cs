namespace NNT_Backend.Entities.Pokemon.Pokemon
{
    public class PokemonMoveVersion
    {
        public MoveLearnMethod move_learn_method { get; set; }
        public VersionGroup version_group { get; set; }
        public int level_learned_at { get; set; }
    }
}
