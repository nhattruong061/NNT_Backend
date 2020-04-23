using System.Collections.Generic;

namespace NNT_Backend.Entities.Moves
{
    public class MoveDamageClass
    {
        public int id { get; set; }
        public string name { get; set; }
        public IList<Name> names { get; set; }
        public IList<Move> moves { get; set; }
        public IList<Description> descriptions { get; set; }
    }
}
