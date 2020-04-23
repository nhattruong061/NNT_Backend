using System.Collections.Generic;

namespace NNT_Backend.Entities.Games
{
    public class Pokedex
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool is_main_series { get; set; }
        public IList<Description> descriptions { get; set; }
        public IList<Name> names { get; set; }
        public IList<PokemonEntry> pokemon_entries { get; set; }
        public Region region { get; set; }
        public IList<VersionGroup> version_groups { get; set; }
    }
}
