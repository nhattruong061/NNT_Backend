using System.Collections.Generic;

namespace NNT_Backend.Entities.Items
{
    public class ItemCategory
    {
        public int id { get; set; }
        public string name { get; set; }
        public IList<Item> items { get; set; }
        public IList<Name> names { get; set; }
        public ItemPocket pocket { get; set; }
    }
}
