using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaVentas.Domain.Entities;

namespace SistemaVentas.Persistence.Configuration;
public class ConfigurationCEConfig : IEntityTypeConfiguration<ConfigurationCE>
{
    public void Configure(EntityTypeBuilder<ConfigurationCE> builder)
    {
        builder.HasKey(x => x.Id);
        builder.ToTable("ConfigurationCE");
        builder.Property(p => p.Resource).HasMaxLength(300);
        builder.Property(p => p.Property).HasMaxLength(300);
        builder.Property(p => p.Value).HasMaxLength(300);
    }
}
