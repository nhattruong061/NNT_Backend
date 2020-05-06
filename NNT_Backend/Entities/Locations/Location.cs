using NNT_Backend.Entities.Utility.CommonModels;
using System.Collections.Generic;

namespace NNT_Backend.Entities.Locations
{
    public class Location
    {
        public int id { get; set; }
        public string name { get; set; }
        public Region region { get; set; }
        public IList<Name> names { get; set; }
        public IList<GenerationGameIndex> game_indices { get; set; }
        public IList<LocationArea> areas { get; set; }
    }
}
