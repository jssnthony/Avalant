using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Cards
{
    public abstract class LivingCardBaseModel : CardBaseModel
    {
        public int Age { get; set; }
        //public GenderEnum Gender { get; set; }

        //public List<TraitCardModel> Traits { get; set; } = new();
        //public List<NeedModel> Needs { get; set; } = new();
        //public List<RelationshipModel> Relationships { get; set; } = new();
    }
}
