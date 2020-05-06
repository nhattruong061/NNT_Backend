namespace NNT_Backend.Entities.Pokemon.Ability
{
    public class AbilityPokemon
    {
        public bool is_hidden { get; set; }
        public int slot { get; set; }
        public Pokemon.Pokemon pokemon { get; set; }
    }
}
