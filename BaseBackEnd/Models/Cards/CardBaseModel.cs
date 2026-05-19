using Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Cards
{
    public class CardBaseModel
    {
        public Guid UniqueId { get; set; }
        public string Name { get; set; }
        public CardTypeEnum CardType { get; set; }
    }
}
