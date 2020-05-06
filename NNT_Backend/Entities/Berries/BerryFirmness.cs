using NNT_Backend.Entities.Utility.CommonModels;
using System.Collections.Generic;

namespace NNT_Backend.Entities.Berries
{
    public class BerryFirmness
    {
        public int id { get; set; }
        public string name { get; set; }
        public IList<Berry> berries { get; set; }
        public IList<Name> names { get; set; }
    }
}
