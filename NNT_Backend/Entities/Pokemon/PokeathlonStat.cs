using System.Collections.Generic;

namespace NNT_Backend.Entities.Pokemon
{
    public class PokeathlonStat
    {
        public int id { get; set; }
        public string name { get; set; }
        public IList<Name> names { get; set; }
        public NaturePokeathlonStatAffectSets affecting_natures { get; set; }
    }
}
