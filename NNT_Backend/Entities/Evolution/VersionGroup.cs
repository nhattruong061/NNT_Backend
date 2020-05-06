using NNT_Backend.Entities.Games;
using NNT_Backend.Entities.Locations;
using NNT_Backend.Entities.Moves;
using System;
using System.Collections.Generic;

namespace NNT_Backend.Entities.Evolution
{
    public class VersionGroup
    {
        public int id { get; set; }
        public string name { get; set; }
        public int order { get; set; }
        public Generation generation { get; set; }
        public IList<MoveLearnMethod> move_learn_methods { get; set; }
        public IList<Pokedex> pokedexes { get; set; }
        public IList<Region> regions { get; set; }
        public IList<Games.Version> versions { get; set; }
    }
}
