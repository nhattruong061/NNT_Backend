using NNT_Backend.Entities.Utility.CommonModels;
using System.Collections.Generic;

namespace NNT_Backend.Entities.Pokemon.Pokemon
{
    public class Pokemon
    {
        public int id { get; set; }
        public string name { get; set; }
        public int base_experience { get; set; }
        public int height { get; set; }
        public bool is_default { get; set; }
        public int order { get; set; }
        public int weight { get; set; }
        public IList<PokemonAbility> abilities { get; set; }
        public IList<PokemonForm> forms { get; set; }
        public IList<VersionGameIndex> game_indices { get; set; }
        public IList<PokemonHeldItem> held_items { get; set; }
        public IList<LocationAreaEncounter> location_area_encounters { get; set; }
        public IList<PokemonMove> moves { get; set; }
        public PokemonSpecies.PokemonSpecies species { get; set; }
        public PokemonSprites sprites { get; set; }
        public IList<Stat> stats { get; set; }
        public IList<PokemonType> types { get; set; }
    }
}
