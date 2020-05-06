using NNT_Backend.Entities.Utility.CommonModels;
using System.Collections.Generic;

namespace NNT_Backend.Entities.Items
{
    public class ItemPocket
    {
        public int id { get; set; }
        public string name { get; set; }
        public IList<ItemCategory> categories { get; set; }
        public IList<Name> names { get; set; }
    }
}
