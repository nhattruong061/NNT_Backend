using NNT_Backend.Entities.Items;

namespace NNT_Backend.Entities.Pokemon.Pokemon
{
    public class PokemonHeldItem
    {
        public Item item { get; set; }
        public PokemonHeldItemVersion version_details { get; set; }
    }
}
