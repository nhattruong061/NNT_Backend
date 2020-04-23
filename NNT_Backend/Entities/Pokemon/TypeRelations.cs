using System.Collections.Generic;

namespace NNT_Backend.Entities.Pokemon
{
    public class TypeRelations
    {
        public IList<Type> no_damage_to { get; set; }
        public IList<Type> half_damage_to { get; set; }
        public IList<Type> double_damage_to { get; set; }
        public IList<Type> no_damage_from { get; set; }
        public IList<Type> half_damage_from { get; set; }
        public IList<Type> double_damage_from { get; set; }
    }
}
