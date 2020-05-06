using NNT_Backend.Entities.Evolution;
using NNT_Backend.Entities.Utility.CommonModels;
using System.Collections.Generic;

namespace NNT_Backend.Entities.Moves
{
    public class MoveLearnMethod
    {
        public int id { get; set; }
        public string name { get; set; }
        public IList<Name> names { get; set; }
        public IList<VersionGroup> version_groups { get; set; }
        public IList<Description> descriptions { get; set; }
    }
}
