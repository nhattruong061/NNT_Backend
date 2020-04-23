using System.Collections.Generic;

namespace NNT_Backend.Entities.Contests
{
    public class SuperContestEffect
    {
        public int id { get; set; }
        public int appeal { get; set; }
        public IList<FlavorText> flavor_text_entries { get; set; }
        public IList<Move> moves { get; set; }
    }
}
