using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NNT_Backend.Entities;
using NNT_Backend.Entities.Berries;
using NNT_Backend.Entities.Contests;
using NNT_Backend.Entities.Encounters;
using NNT_Backend.Entities.Evolution;
using NNT_Backend.Entities.Games;
using NNT_Backend.Entities.Items;
using NNT_Backend.Entities.Locations;
using NNT_Backend.Entities.Machines;
using NNT_Backend.Entities.Moves;
using NNT_Backend.Entities.Pokemon;
using NNT_Backend.Entities.Pokemon.Ability;
using NNT_Backend.Entities.Pokemon.Pokemon;
using NNT_Backend.Entities.Pokemon.PokemonSpecies;
using NNT_Backend.Entities.Utility;
using NNT_Backend.Entities.Utility.CommonModels;

namespace NNT_Backend.Helpers
{
    public class DataContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public DataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sql server database
            options.UseSqlServer(Configuration.GetConnectionString("NNT_BackendDatabase"));
        }

        #region Dbsets
        public DbSet<User> Users { get; set; }

        // Berries
        public DbSet<Berry> Berries { get; set; }
        public DbSet<BerryFirmness> BerryFirmnesses { get; set; }
        public DbSet<BerryFlavor> BerryFlavors { get; set; }
        public DbSet<BerryFlavorMap> BerryFlavorMaps { get; set; }

        // Contests
        public DbSet<ContestEffect> ContestEffects { get; set; }
        public DbSet<ContestName> ContestNames { get; set; }
        public DbSet<ContestType> ContestTypes { get; set; }
        public DbSet<SuperContestEffect> SuperContestEffects { get; set; }

        // Encounters
        public DbSet<EncounterCondition> EncounterConditions { get; set; }
        public DbSet<EncounterConditionValue> EncounterConditionValues { get; set; }
        public DbSet<EncounterMethod> EncounterMethods { get; set; }

        // Evolution
        public DbSet<ChainLink> ChainLinks { get; set; }
        public DbSet<EvolutionChain> EvolutionChains { get; set; }
        public DbSet<EvolutionDetail> EvolutionDetails { get; set; }
        public DbSet<EvolutionTrigger> EvolutionTriggers { get; set; }
        public DbSet<VersionGroup> VersionGroups { get; set; }

        // Games
        public DbSet<Generation> Generations { get; set; }
        public DbSet<Pokedex> Pokedexs { get; set; }
        public DbSet<PokemonEntry> PokemonEntries { get; set; }
        public DbSet<Version> Versions { get; set; }

        // Items
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemAttribute> ItemAttributes { get; set; }
        public DbSet<ItemCategory> ItemCategories { get; set; }
        public DbSet<ItemFlingEffect> ItemFlingEffects { get; set; }
        public DbSet<ItemHolderPokemon> ItemHolderPokemons { get; set; }
        public DbSet<ItemHolderPokemonVersionDetail> ItemHolderPokemonVersionDetails { get; set; }
        public DbSet<ItemPocket> ItemPockets { get; set; }
        public DbSet<ItemSprites> ItemSprites { get; set; }

        // Locations
        public DbSet<EncounterMethodRate> EncounterMethodRates { get; set; }
        public DbSet<EncounterVersionDetails> EncounterVersionDetails { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<LocationArea> LocationAreas { get; set; }
        public DbSet<PalParkArea> PalParkAreas { get; set; }
        public DbSet<PalParkEncounterSpecies> PalParkEncounterSpecies { get; set; }
        public DbSet<PokemonEncounter> PokemonEncounters { get; set; }
        public DbSet<Region> Regions { get; set; }

        // Machines
        public DbSet<Machine> Machines { get; set; }

        // Moves
        public DbSet<ContestComboDetail> ContestComboDetails { get; set; }
        public DbSet<ContestComboSets> ContestComboSets { get; set; }
        public DbSet<ModelName> ModelNames { get; set; }
        public DbSet<Move> Moves { get; set; }
        public DbSet<MoveAilment> MoveAilments { get; set; }
        public DbSet<MoveBattleStyle> MoveBattleStyles { get; set; }
        public DbSet<MoveCategory> MoveCategories { get; set; }
        public DbSet<MoveDamageClass> moveDamageClasses { get; set; }
        public DbSet<MoveFlavorText> MoveFlavorTexts { get; set; }
        public DbSet<MoveLearnMethod> MoveLearnMethods { get; set; }
        public DbSet<MoveMetaData> MoveMetaDatas { get; set; }
        public DbSet<MoveStatChange> MoveStatChanges { get; set; }
        public DbSet<MoveTarget> MoveTargets { get; set; }
        public DbSet<PastMoveStatValues> PastMoveStatValues { get; set; }

        // Pokemons
        public DbSet<Ability> Abilities { get; set; }
        public DbSet<AbilityEffectChange> AbilityEffectChanges { get; set; }
        public DbSet<AbilityFlavorText> AbilityFlavorTexts { get; set; }
        public DbSet<AbilityPokemon> AbilityPokemons { get; set; }

        public DbSet<LocationAreaEncounter> LocationAreaEncounters { get; set; }
        public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<PokemonAbility> PokemonAbilities { get; set; }
        public DbSet<PokemonHeldItem> PokemonHeldItems { get; set; }
        public DbSet<PokemonHeldItemVersion> PokemonHeldItemVersions { get; set; }
        public DbSet<PokemonMove> PokemonMoves { get; set; }
        public DbSet<PokemonMoveVersion> PokemonMoveVersions { get; set; }
        public DbSet<PokemonSprites> PokemonSprites { get; set; }
        public DbSet<PokemonStat> pokemonStats { get; set; }
        public DbSet<PokemonType> pokemonTypes { get; set; }

        public DbSet<Genus> Genus { get; set; }
        public DbSet<PalParkEncounterArea> PalParkEncounterAreas { get; set; }
        public DbSet<PokemonSpecies> PokemonSpecies { get; set; }
        public DbSet<PokemonSpeciesDexEntry> GetPokemonSpeciesDexEntries { get; set; }
        public DbSet<PokemonSpeciesVariety> PokemonSpeciesVarieties { get; set; }

        public DbSet<AwesomeName> AwesomeNames { get; set; }
        public DbSet<Characteristic> Characteristics { get; set; }
        public DbSet<EggGroup> EggGroups { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<GrowthRate> GrowthRates { get; set; }
        public DbSet<GrowthRateExperienceLevel> GrowthRateExperienceLevels { get; set; }
        public DbSet<MoveBattleStylePreference> MoveBattleStylePreferences { get; set; }
        public DbSet<MoveStatAffect> MoveStatAffects { get; set; }
        public DbSet<MoveStatAffectSets> MoveStatAffectSets { get; set; }
        public DbSet<Nature> Natures { get; set; }
        public DbSet<NaturePokeathlonStatAffect> NaturePokeathlonStatAffects { get; set; }
        public DbSet<NaturePokeathlonStatAffectSets> NaturePokeathlonStatAffectSets { get; set; }
        public DbSet<NatureStatAffectSets> NatureStatAffectSets { get; set; }
        public DbSet<NatureStatChange> NatureStatChanges { get; set; }
        public DbSet<PokeathlonStat> PokeathlonStats { get; set; }
        public DbSet<PokemonColor> PokemonColors { get; set; }
        public DbSet<PokemonForm> PokemonForms { get; set; }
        public DbSet<PokemonFormSprites> PokemonFormSprites { get; set; }
        public DbSet<PokemonHabitat> PokemonHabitats { get; set; }
        public DbSet<PokemonShape> PokemonShapes { get; set; }
        public DbSet<PokemonSpeciesGender> PokemonSpeciesGenders { get; set; }
        public DbSet<Stat> Stats { get; set; }
        public DbSet<Type> Types { get; set; }
        public DbSet<TypePokemon> TypePokemons { get; set; }
        public DbSet<TypeRelations> TypeRelations { get; set; }

        // Utility
        public DbSet<Language> Languages { get; set; }

        public DbSet<APIResource> APIResources { get; set; }
        public DbSet<Description> Descriptions { get; set; }
        public DbSet<Effect> Effects { get; set; }
        public DbSet<Encounter> Encounters { get; set; }
        public DbSet<FlavorText> FlavorTexts { get; set; }
        public DbSet<GenerationGameIndex> GenerationGameIndices { get; set; }
        public DbSet<MachineVersionDetail> MachineVersionDetails { get; set; }
        public DbSet<Name> Names { get; set; }
        public DbSet<NamedAPIResource> NamedAPIResources { get; set; }
        public DbSet<VerboseEffect> VerboseEffects { get; set; }
        public DbSet<VersionEncounterDetail> VersionEncounterDetails { get; set; }
        public DbSet<VersionGameIndex> VersionGameIndices { get; set; }
        public DbSet<VersionGroupFlavorText> VersionGroupFlavorTexts { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Berries
            modelBuilder.Entity<Berry>().HasMany(b => b.flavors);
            modelBuilder.Entity<Berry>().HasOne(b => b.firmness).WithMany(f => f.berries);
            modelBuilder.Entity<Berry>().HasOne(b => b.item);
            modelBuilder.Entity<Berry>().HasOne(b => b.natural_gift_type);

            modelBuilder.Entity<BerryFirmness>().HasMany(b => b.names);

            modelBuilder.Entity<BerryFlavor>().HasMany(b => b.berries);
            modelBuilder.Entity<BerryFlavor>().HasOne(b => b.contest_type);
            modelBuilder.Entity<BerryFlavor>().HasMany(b => b.names);

            modelBuilder.Entity<BerryFlavorMap>().HasOne(b => b.flavor);

            // Contests
            modelBuilder.Entity<ContestEffect>().HasMany(c => c.effect_entries);
            modelBuilder.Entity<ContestEffect>().HasMany(c => c.flavor_text_entries);

            modelBuilder.Entity<ContestName>().HasOne(c => c.language);

            modelBuilder.Entity<ContestType>().HasOne(c => c.berry_flavor);
            modelBuilder.Entity<ContestType>().HasMany(c => c.names);

            // Encounters
            modelBuilder.Entity<EncounterCondition>().HasMany(e => e.values);
            modelBuilder.Entity<EncounterCondition>().HasMany(e => e.names);

            modelBuilder.Entity<EncounterConditionValue>().HasOne(e => e.condition);
            modelBuilder.Entity<EncounterConditionValue>().HasMany(e => e.names);

            modelBuilder.Entity<EncounterMethod>().HasMany(e => e.names);

            // Evolution
            modelBuilder.Entity<ChainLink>().HasOne(e => e.species);
            modelBuilder.Entity<ChainLink>().HasMany(e => e.evolution_details);
            modelBuilder.Entity<ChainLink>().HasMany(e => e.evolves_to);

            modelBuilder.Entity<EvolutionChain>().HasOne(e => e.baby_trigger_item);
            modelBuilder.Entity<EvolutionChain>().HasOne(e => e.chain);

            modelBuilder.Entity<EvolutionDetail>().HasOne(e => e.item);
            modelBuilder.Entity<EvolutionDetail>().HasOne(e => e.trigger);
            modelBuilder.Entity<EvolutionDetail>().HasOne(e => e.held_item);
            modelBuilder.Entity<EvolutionDetail>().HasOne(e => e.known_move);
            modelBuilder.Entity<EvolutionDetail>().HasOne(e => e.known_move_type);
            modelBuilder.Entity<EvolutionDetail>().HasOne(e => e.location);
            modelBuilder.Entity<EvolutionDetail>().HasOne(e => e.party_species);
            modelBuilder.Entity<EvolutionDetail>().HasOne(e => e.party_type);
            modelBuilder.Entity<EvolutionDetail>().HasOne(e => e.trade_species);

            modelBuilder.Entity<EvolutionTrigger>().HasMany(e => e.names);
            modelBuilder.Entity<EvolutionTrigger>().HasMany(e => e.pokemon_species);

            modelBuilder.Entity<VersionGroup>().HasOne(e => e.generation);
            modelBuilder.Entity<VersionGroup>().HasMany(e => e.move_learn_methods);
            modelBuilder.Entity<VersionGroup>().HasMany(e => e.pokedexes);
            modelBuilder.Entity<VersionGroup>().HasMany(e => e.regions);
            modelBuilder.Entity<VersionGroup>().HasMany(e => e.versions);

            // Games
            modelBuilder.Entity<Generation>().HasMany(g => g.abilities);
            modelBuilder.Entity<Generation>().HasOne(g => g.main_region);
            modelBuilder.Entity<Generation>().HasMany(g => g.moves);
            modelBuilder.Entity<Generation>().HasMany(g => g.names);
            modelBuilder.Entity<Generation>().HasMany(g => g.pokemon_species);
            modelBuilder.Entity<Generation>().HasMany(g => g.types);
            modelBuilder.Entity<Generation>().HasMany(g => g.version_groups);

            modelBuilder.Entity<Pokedex>().HasMany(g => g.descriptions);
            modelBuilder.Entity<Pokedex>().HasMany(g => g.names);
            modelBuilder.Entity<Pokedex>().HasMany(g => g.pokemon_entries);
            modelBuilder.Entity<Pokedex>().HasOne(g => g.region);
            modelBuilder.Entity<Pokedex>().HasMany(g => g.version_groups);

            modelBuilder.Entity<PokemonEntry>().HasOne(g => g.pokemon_species);

            modelBuilder.Entity<Version>().HasMany(g => g.names);
            modelBuilder.Entity<Version>().HasOne(g => g.version_group);

            // Items
            modelBuilder.Entity<Item>().HasOne(i => i.fling_effect);
            modelBuilder.Entity<Item>().HasMany(i => i.attributes);
            modelBuilder.Entity<Item>().HasOne(i => i.category);
            modelBuilder.Entity<Item>().HasMany(i => i.effect_entries);
            modelBuilder.Entity<Item>().HasMany(i => i.flavor_text_entries);
            modelBuilder.Entity<Item>().HasMany(i => i.game_indices);
            modelBuilder.Entity<Item>().HasMany(i => i.names);
            modelBuilder.Entity<Item>().HasOne(i => i.sprites);
            modelBuilder.Entity<Item>().HasMany(i => i.held_by_pokemon);
            modelBuilder.Entity<Item>().HasOne(i => i.baby_trigger_for);
            modelBuilder.Entity<Item>().HasMany(i => i.machines);

            modelBuilder.Entity<ItemAttribute>().HasMany(i => i.descriptions);
            modelBuilder.Entity<ItemAttribute>().HasMany(i => i.items);
            modelBuilder.Entity<ItemAttribute>().HasMany(i => i.names);

            modelBuilder.Entity<ItemCategory>().HasMany(i => i.items);
            modelBuilder.Entity<ItemCategory>().HasMany(i => i.names);
            modelBuilder.Entity<ItemCategory>().HasOne(i => i.pocket);

            modelBuilder.Entity<ItemFlingEffect>().HasMany(i => i.effect_entries);
            modelBuilder.Entity<ItemFlingEffect>().HasMany(i => i.items);

            modelBuilder.Entity<ItemHolderPokemon>().HasOne(i => i.pokemon);
            modelBuilder.Entity<ItemHolderPokemon>().HasMany(i => i.version_details);

            modelBuilder.Entity<ItemHolderPokemonVersionDetail>().HasOne(i => i.version);

            modelBuilder.Entity<ItemPocket>().HasMany(i => i.categories);
            modelBuilder.Entity<ItemPocket>().HasMany(i => i.names);

            // Locations
            modelBuilder.Entity<EncounterMethodRate>().HasOne(l => l.encounter_method);
            modelBuilder.Entity<EncounterMethodRate>().HasMany(l => l.version_details);

            modelBuilder.Entity<EncounterVersionDetails>().HasOne(l => l.version);

            modelBuilder.Entity<Location>().HasOne(l => l.region);
            modelBuilder.Entity<Location>().HasMany(l => l.names);
            modelBuilder.Entity<Location>().HasMany(l => l.game_indices);
            modelBuilder.Entity<Location>().HasMany(l => l.areas);

            modelBuilder.Entity<LocationArea>().HasOne(l => l.location);
            modelBuilder.Entity<LocationArea>().HasMany(l => l.names);
            modelBuilder.Entity<LocationArea>().HasMany(l => l.encounter_method_rates);
            modelBuilder.Entity<LocationArea>().HasMany(l => l.pokemon_encounters);

            modelBuilder.Entity<PalParkArea>().HasMany(l => l.names);
            modelBuilder.Entity<PalParkArea>().HasMany(l => l.pokemon_encounters);

            modelBuilder.Entity<PalParkEncounterSpecies>().HasOne(l => l.pokemon_species);

            modelBuilder.Entity<PokemonEncounter>().HasOne(l => l.pokemon);
            modelBuilder.Entity<PokemonEncounter>().HasMany(l => l.version_details);

            modelBuilder.Entity<Region>().HasOne(l => l.main_generation);
            modelBuilder.Entity<Region>().HasMany(l => l.names);
            modelBuilder.Entity<Region>().HasMany(l => l.pokedexes);
            modelBuilder.Entity<Region>().HasMany(l => l.version_groups);
            modelBuilder.Entity<Region>().HasMany(l => l.locations);

            // Machines
            modelBuilder.Entity<Machine>().HasOne(m => m.item);
            modelBuilder.Entity<Machine>().HasOne(m => m.move);
            modelBuilder.Entity<Machine>().HasOne(m => m.version_group);

            // Moves
            modelBuilder.Entity<ContestComboDetail>().HasOne(m => m.use_after);
            modelBuilder.Entity<ContestComboDetail>().HasOne(m => m.use_before);

            modelBuilder.Entity<ContestComboSets>().HasOne(m => m.normal);
            modelBuilder.Entity<ContestComboSets>().HasOne(m => m.super);

            modelBuilder.Entity<Move>().HasOne(m => m.contest_combos);
            modelBuilder.Entity<Move>().HasOne(m => m.contest_effect);
            modelBuilder.Entity<Move>().HasOne(m => m.contest_type);
            modelBuilder.Entity<Move>().HasOne(m => m.damage_class);
            modelBuilder.Entity<Move>().HasMany(m => m.effect_entries);
            modelBuilder.Entity<Move>().HasMany(m => m.effect_changes);
            modelBuilder.Entity<Move>().HasOne(m => m.generation);
            modelBuilder.Entity<Move>().HasOne(m => m.meta);
            modelBuilder.Entity<Move>().HasOne(m => m.machines);
            modelBuilder.Entity<Move>().HasMany(m => m.past_values);
            modelBuilder.Entity<Move>().HasMany(m => m.stat_changes);
            modelBuilder.Entity<Move>().HasMany(m => m.flavor_text_entries);
            modelBuilder.Entity<Move>().HasMany(m => m.names);
            modelBuilder.Entity<Move>().HasOne(m => m.type);
            modelBuilder.Entity<Move>().HasOne(m => m.target);
            modelBuilder.Entity<Move>().HasOne(m => m.super_contest_effect);

            modelBuilder.Entity<ModelName>().HasMany(m => m.moves);
            modelBuilder.Entity<ModelName>().HasMany(m => m.descriptions);

            modelBuilder.Entity<MoveAilment>().HasMany(m => m.moves);
            modelBuilder.Entity<MoveAilment>().HasMany(m => m.names);

            modelBuilder.Entity<MoveBattleStyle>().HasMany(m => m.names);

            modelBuilder.Entity<MoveCategory>().HasOne(m => m.name);

            modelBuilder.Entity<MoveDamageClass>().HasMany(m => m.moves);
            modelBuilder.Entity<MoveDamageClass>().HasMany(m => m.descriptions);
            modelBuilder.Entity<MoveDamageClass>().HasMany(m => m.names);

            modelBuilder.Entity<MoveFlavorText>().HasOne(m => m.language);
            modelBuilder.Entity<MoveFlavorText>().HasOne(m => m.version_group);

            modelBuilder.Entity<MoveLearnMethod>().HasMany(m => m.version_groups);
            modelBuilder.Entity<MoveLearnMethod>().HasMany(m => m.names);
            modelBuilder.Entity<MoveLearnMethod>().HasMany(m => m.descriptions);

            modelBuilder.Entity<MoveMetaData>().HasOne(m => m.ailment);
            modelBuilder.Entity<MoveMetaData>().HasOne(m => m.category);

            modelBuilder.Entity<MoveStatChange>().HasOne(m => m.stat);

            modelBuilder.Entity<MoveTarget>().HasMany(m => m.descriptions);
            modelBuilder.Entity<MoveTarget>().HasMany(m => m.names);
            modelBuilder.Entity<MoveTarget>().HasMany(m => m.moves);

            modelBuilder.Entity<PastMoveStatValues>().HasOne(m => m.type);
            modelBuilder.Entity<PastMoveStatValues>().HasOne(m => m.version_group);
            modelBuilder.Entity<PastMoveStatValues>().HasMany(m => m.effect_entries);

            // Pokemons

            // Utility
        }
    }
}