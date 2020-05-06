using NNT_Backend.Entities.Utility.CommonModels;
using System.Collections.Generic;

namespace NNT_Backend.Entities.Moves
{
    public class MoveBattleStyle
    {
        public int id { get; set; }
        public string name { get; set; }
        public IList<Name> names { get; set; }
    }
}
