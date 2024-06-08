using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebAppOgani.Models.Entities;

namespace WebAppOgani.Models.Contexts.Configurations
{
    public class SubscribePostEntityTypeConfiguration : IEntityTypeConfiguration<SubscribePost>
    {
        public void Configure(EntityTypeBuilder<SubscribePost> builder)
        {
            builder.Property(m => m.Email).HasColumnType("varchar").HasMaxLength(100);

            builder.HasKey(m => m.Email);
        }
    }
}
