using System;
using System.Collections.Generic;
using System.Text;

namespace Avalant.Domain.Models
{
    public class CardRelationEntity
    {
        public Guid Id { get; set; }

        public Guid SourceCardId { get; set; }
        public Guid PredicateCardId { get; set; }
        public Guid TargetCardId { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public CardEntity SourceCard { get; set; } = null!;
        public CardEntity PredicateCard { get; set; } = null!;
        public CardEntity TargetCard { get; set; } = null!;
    }
}
