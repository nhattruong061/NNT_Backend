using System.Collections.Generic;

namespace NNT_Backend.Entities.Pokemon
{
    public class Characteristic
    {
        public int id { get; set; }
        public int gene_modulo { get; set; }
        public IList<int> possible_values { get; set; }
    }
}
