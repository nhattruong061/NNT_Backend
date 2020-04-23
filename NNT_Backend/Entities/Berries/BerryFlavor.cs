using NNT_Backend.Entities.Contests;
using System.Collections.Generic;

namespace NNT_Backend.Entities.Berries
{
    public class BerryFlavor
    {
        public int id { get; set; }
        public string name { get; set; }
        public IList<Berry> berries { get; set; }
        public ContestType contest_type { get; set; }
        public IList<Name> names { get; set; }
    }
}
