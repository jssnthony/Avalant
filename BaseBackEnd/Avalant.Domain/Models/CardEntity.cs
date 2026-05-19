using System;
using System.Collections.Generic;
using System.Text;

namespace Avalant.Domain.Models
{
    public class CardEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string CardType { get; set; } = string.Empty;
        public string? Description { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public ICollection<CardRelationEntity> SourceRelations { get; set; } = new List<CardRelationEntity>();
        public ICollection<CardRelationEntity> PredicateRelations { get; set; } = new List<CardRelationEntity>();
        public ICollection<CardRelationEntity> TargetRelations { get; set; } = new List<CardRelationEntity>();
    }
}
