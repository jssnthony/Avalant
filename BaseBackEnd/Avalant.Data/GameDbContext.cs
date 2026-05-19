using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace Avalant.Data
{
    public class GameDbContext : DbContext
    {
        public GameDbContext(DbContextOptions<GameDbContext> options)
            : base(options)
        {
        }

        public DbSet<CardEntity> Cards => Set<CardEntity>();
        public DbSet<CardRelationEntity> CardRelations => Set<CardRelationEntity>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CardEntity>(entity =>
            {
                entity.ToTable("Cards");

                entity.HasKey(x => x.Id);

                entity.Property(x => x.Name)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(x => x.CardType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasIndex(x => x.CardType);
            });

            modelBuilder.Entity<CardRelationEntity>(entity =>
            {
                entity.ToTable("CardRelations");

                entity.HasKey(x => x.Id);

                entity.HasOne(x => x.SourceCard)
                    .WithMany(x => x.SourceRelations)
                    .HasForeignKey(x => x.SourceCardId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(x => x.PredicateCard)
                    .WithMany(x => x.PredicateRelations)
                    .HasForeignKey(x => x.PredicateCardId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(x => x.TargetCard)
                    .WithMany(x => x.TargetRelations)
                    .HasForeignKey(x => x.TargetCardId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasIndex(x => x.SourceCardId);
                entity.HasIndex(x => x.PredicateCardId);
                entity.HasIndex(x => x.TargetCardId);

                entity.HasIndex(x =>
                    new
                    {
                        x.SourceCardId,
                        x.PredicateCardId,
                        x.TargetCardId
                    })
                    .IsUnique();
            });
        }
    }
}
