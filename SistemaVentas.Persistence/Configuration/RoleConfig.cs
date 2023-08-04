using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaVentas.Domain.Entities;

namespace SistemaVentas.Persistence.Configuration;
public class RoleConfig : IEntityTypeConfiguration<Role>
{
    public void Configure(EntityTypeBuilder<Role> builder)
    {
        builder.ToTable(nameof(Role));
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Name).HasMaxLength(300);
        builder.Property(p => p.Description).HasMaxLength(300);
        builder.Property(p => p.IsActive).HasColumnType("bit");
    }
}
