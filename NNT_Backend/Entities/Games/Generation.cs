using System;
using System.Collections.Generic;

namespace NNT_Backend.Entities.Games
{
    public class Generation
    {
        public int id { get; set; }
        public string name { get; set; }
        public IList<Ability> abilities { get; set; }
        public Region main_region { get; set; }
        public IList<Move> moves { get; set; }
        public IList<Name> names { get; set; }
        public IList<PokemonSpecies> pokemon_species { get; set; }
        public IList<Type> types { get; set; }
        public IList<VersionGroup> version_groups { get; set; }
    }
}
