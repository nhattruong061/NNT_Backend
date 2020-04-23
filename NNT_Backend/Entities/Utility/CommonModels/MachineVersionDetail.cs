using NNT_Backend.Entities.Evolution;
using NNT_Backend.Entities.Machines;

namespace NNT_Backend.Entities.Utility.CommonModels
{
    public class MachineVersionDetail
    {
        public Machine machine { get; set; }
        public VersionGroup version_group { get; set; }
    }
}
