using System.Collections.Generic;

namespace NNT_Backend.Entities.Contests
{
    public class ContestEffect
    {
        public int id { get; set; }
        public int appeal { get; set; }
        public int jam { get; set; }
        public IList<Effect> effect_entries { get; set; }
        public IList<FlavorText> flavor_text_entries { get; set; }
    }
}
