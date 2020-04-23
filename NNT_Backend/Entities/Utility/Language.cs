using NNT_Backend.Entities.Utility.CommonModels;
using System.Collections.Generic;

namespace NNT_Backend.Entities.Utility
{
    public class Language
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool official { get; set; }
        public string iso639 { get; set; }
        public string iso3166 { get; set; }
        public IList<Name> names { get; set; }
    }
}
