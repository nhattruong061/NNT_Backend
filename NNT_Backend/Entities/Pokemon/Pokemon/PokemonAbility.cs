namespace NNT_Backend.Entities.Pokemon.Pokemon
{
    public class PokemonAbility
    {
        public bool is_hidden { get; set; }
        public int slot { get; set; }
        public Ability.Ability ability { get; set; }
    }
}
