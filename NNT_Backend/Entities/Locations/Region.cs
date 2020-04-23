using System.Collections.Generic;

namespace NNT_Backend.Entities.Locations
{
    public class Region
    {
        public int id { get; set; }
        public string name { get; set; }
        public IList<Location> locations { get; set; }
        public Generation main_generation { get; set; }
        public IList<Name> names { get; set; }
        public IList<Pokedex> pokedexes { get; set; }
        public IList<VersionGroup> version_groups { get; set; }
    }
}
