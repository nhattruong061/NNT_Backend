using NNT_Backend.Entities.Moves;

namespace NNT_Backend.Entities.Pokemon.Pokemon
{
    public class PokemonMove
    {
        public Move move { get; set; }
        public PokemonMoveVersion version_group_details { get; set; }
    }
}
