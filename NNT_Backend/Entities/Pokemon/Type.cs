using NNT_Backend.Entities.Games;
using NNT_Backend.Entities.Moves;
using NNT_Backend.Entities.Utility.CommonModels;
using System.Collections.Generic;

namespace NNT_Backend.Entities.Pokemon
{
    public class Type
    {
        public int id { get; set; }
        public string name { get; set; }
        public TypeRelations damage_relations { get; set; }
        public IList<GenerationGameIndex> game_indices { get; set; }
        public Generation generation { get; set; }
        public MoveDamageClass move_damage_class { get; set; }
        public IList<Name> names { get; set; }
        public IList<TypePokemon> pokemon { get; set; }
        public IList<Move> moves { get; set; }
    }
}