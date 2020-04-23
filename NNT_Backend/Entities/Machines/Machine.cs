using NNT_Backend.Entities.Evolution;
using NNT_Backend.Entities.Items;

namespace NNT_Backend.Entities.Machines
{
    public class Machine
    {
        public int id { get; set; }
        public Item item { get; set; }
        public Move move { get; set; }
        public VersionGroup version_group { get; set; }
    }
}
