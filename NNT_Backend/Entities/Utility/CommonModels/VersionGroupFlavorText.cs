using NNT_Backend.Entities.Evolution;

namespace NNT_Backend.Entities.Utility.CommonModels
{
    public class VersionGroupFlavorText
    {
        public string text { get; set; }
        public Language language { get; set; }
        public VersionGroup Version_group { get; set; }
    }
}
