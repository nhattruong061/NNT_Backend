using NNT_Backend.Entities.Utility.CommonModels;
using System.Collections.Generic;

namespace NNT_Backend.Entities.Items
{
    public class ItemFlingEffect
    {
        public int id { get; set; }
        public string name { get; set; }
        public IList<Effect> effect_entries { get; set; }
        public IList<Item> items { get; set; }
    }
}
