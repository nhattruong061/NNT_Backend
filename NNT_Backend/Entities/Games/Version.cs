using NNT_Backend.Entities.Evolution;
using NNT_Backend.Entities.Utility.CommonModels;
using System.Collections.Generic;

namespace NNT_Backend.Entities.Games
{
    public class Version
    {
        public int id { get; set; }
        public string name { get; set; }
        public IList<Name> names { get; set; }
        public VersionGroup version_group { get; set; }
    }
}
