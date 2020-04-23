using System.Collections.Generic;

namespace NNT_Backend.Entities.Items
{
    public class ItemHolderPokemon
    {
        public Pokemon pokemon { get; set; }
        public IList<ItemHolderPokemonVersionDetail> version_details { get; set; }
    }
}
