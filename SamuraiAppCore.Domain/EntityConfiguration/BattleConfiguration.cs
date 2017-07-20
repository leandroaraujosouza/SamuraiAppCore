using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SamuraiAppCore.Domain.EntityConfiguration
{
    public class BattleConfiguration : EntityTypeConfiguration<Battle>
    {
        public override void Map(EntityTypeBuilder<Battle> builder)
        {
            builder.Property(e => e.Id).IsRequired();

            builder.HasKey(e => e.Id);
        }
    }
}
