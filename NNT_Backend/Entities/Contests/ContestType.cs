using NNT_Backend.Entities.Berries;
using System.Collections.Generic;

namespace NNT_Backend.Entities.Contests
{
    public class ContestType
    {
        public int id { get; set; }
        public string name { get; set; }
        public BerryFlavor berry_flavor { get; set; }
        public IList<ContestName> names { get; set; }
    }
}
