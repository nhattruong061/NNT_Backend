using NNT_Backend.Entities.Evolution;
using NNT_Backend.Entities.Utility;

namespace NNT_Backend.Entities.Pokemon.Ability
{
    public class AbilityFlavorText
    {
        public string flavor_text { get; set; }
        public Language language { get; set; }
        public VersionGroup version_group { get; set; }
    }
}
