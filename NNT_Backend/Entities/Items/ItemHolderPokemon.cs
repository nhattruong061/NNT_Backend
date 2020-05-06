using System.Collections.Generic;
using NNT_Backend.Entities.Pokemon;

namespace NNT_Backend.Entities.Items
{
    public class ItemHolderPokemon
    {
        public Pokemon.Pokemon.Pokemon pokemon { get; set; }
        public IList<ItemHolderPokemonVersionDetail> version_details { get; set; }
    }
}
