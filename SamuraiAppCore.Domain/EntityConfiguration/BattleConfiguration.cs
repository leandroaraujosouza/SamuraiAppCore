using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SamuraiAppCore.Domain.EntityConfiguration
{
    public class BattleConfiguration : EntityTypeConfiguration<Battle>
    {
        public override void Map(EntityTypeBuilder<Battle> entity)
        {
            entity.Property(e => e.Id).IsRequired();

            entity.HasKey(e => e.Id);
        }
    }
}
