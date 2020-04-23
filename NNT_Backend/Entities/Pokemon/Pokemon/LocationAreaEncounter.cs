using NNT_Backend.Entities.Locations;

namespace NNT_Backend.Entities.Pokemon.Pokemon
{
    public class LocationAreaEncounter
    {
        public LocationArea location_area { get; set; }
        public VersionEncounterDetail version_details { get; set; }
    }
}
