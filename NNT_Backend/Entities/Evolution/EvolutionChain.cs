namespace NNT_Backend.Entities.Evolution
{
    public class EvolutionChain
    {
        public int id { get; set; }
        public Item baby_trigger_item { get; set; }
        public ChainLink chain { get; set; }
    }
}
