using NNT_Backend.Entities.Evolution;
using NNT_Backend.Entities.Games;
using NNT_Backend.Entities.Utility.CommonModels;
using System.Collections.Generic;

namespace NNT_Backend.Entities.Pokemon.PokemonSpecies
{
    public class PokemonSpecies
    {
        public int id { get; set; }
        public string name { get; set; }
        public int order { get; set; }
        public int gender_rate { get; set; }
        public int capture_rate { get; set; }
        public int base_happiness { get; set; }
        public bool is_baby { get; set; }
        public int hatch_counter { get; set; }
        public bool has_gender_differences { get; set; }
        public bool forms_switchable { get; set; }
        public GrowthRate growth_rate { get; set; }
        public IList<PokemonSpeciesDexEntry> pokedex_numbers { get; set; }
        public IList<EggGroup> egg_groups { get; set; }
        public PokemonColor color { get; set; }
        public PokemonShape shape { get; set; }
        public PokemonSpecies evolves_from_species { get; set; }
        public EvolutionChain evolution_chain { get; set; }
        public PokemonHabitat habitat { get; set; }
        public Generation generation { get; set; }
        public IList<Name> names { get; set; }
        public IList<PalParkEncounterArea> pal_park_encounters { get; set; }
        public IList<FlavorText> flavor_text_entries { get; set; }
        public IList<Description> form_descriptions { get; set; }
        public IList<Genus> genera { get; set; }
        public IList<PokemonSpeciesVariety> varieties { get; set; }
    }
}
