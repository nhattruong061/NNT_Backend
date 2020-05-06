using NNT_Backend.Entities.Evolution;
using NNT_Backend.Entities.Utility.CommonModels;
using System.Collections.Generic;

namespace NNT_Backend.Entities.Items
{
    public class Item
    {
        public int id { get; set; }
        public string name { get; set; }
        public int cost { get; set; }
        public int fling_power { get; set; }
        public ItemFlingEffect fling_effect { get; set; }
        public IList<ItemAttribute> attributes { get; set; }
        public ItemCategory category { get; set; }
        public IList<VerboseEffect> effect_entries { get; set; }
        public IList<VersionGroupFlavorText> flavor_text_entries { get; set; }
        public IList<GenerationGameIndex> game_indices { get; set; }
        public IList<Name> names { get; set; }
        public ItemSprites sprites { get; set; }
        public IList<ItemHolderPokemon> held_by_pokemon { get; set; }
        public EvolutionChain baby_trigger_for { get; set; }
        public IList<MachineVersionDetail> machines { get; set; }
    }
}
