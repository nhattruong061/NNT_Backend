using System;

namespace NNT_Backend.Entities.Evolution
{
    public class EvolutionDetail
    {
        public Item item { get; set; }
        public EvolutionTrigger trigger { get; set; }
        public int gender { get; set; }
        public Item held_item { get; set; }
        public Move known_move { get; set; }
        public Type known_move_type { get; set; }
        public Location location { get; set; }
        public int min_level { get; set; }
        public int min_happiness { get; set; }
        public int min_beauty { get; set; }
        public int min_affection { get; set; }
        public bool needs_overworld_rain { get; set; }
        public PokemonSpecies party_species { get; set; }
        public Type party_type { get; set; }
        public int relative_physical_stats { get; set; }
        public string time_of_day { get; set; }
        public PokemonSpecies trade_species { get; set; }
        public bool turn_upside_down { get; set; }
    }
}
