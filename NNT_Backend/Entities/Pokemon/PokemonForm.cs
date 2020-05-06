using NNT_Backend.Entities.Evolution;
using NNT_Backend.Entities.Utility.CommonModels;
using System.Collections.Generic;

namespace NNT_Backend.Entities.Pokemon
{
    public class PokemonForm
    {
        public int id { get; set; }
        public string name { get; set; }
        public int order { get; set; }
        public int form_order { get; set; }
        public bool is_default { get; set; }
        public bool is_battle_only { get; set; }
        public bool is_mega { get; set; }
        public string form_name { get; set; }
        public Pokemon.Pokemon pokemon { get; set; }
        public PokemonFormSprites sprites { get; set; }
        public VersionGroup version_group { get; set; }
        public IList<Name> names { get; set; }
        public IList<Name> form_names { get; set; }
    }
}
