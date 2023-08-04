using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaVentas.Domain.Entities;

namespace SistemaVentas.Persistence.Configuration;
public class MenuConfig : IEntityTypeConfiguration<Menu>
{
    public void Configure(EntityTypeBuilder<Menu> builder)
    {
        builder.ToTable("Menu");
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Descriptions).HasMaxLength(300);
        builder.Property(p => p.Icon).HasMaxLength(300);
        builder.Property(p => p.Controller).HasMaxLength(300);
        builder.Property(p => p.Pagination).HasMaxLength(300);
        builder.Property(p => p.IsActive).HasMaxLength(5);
        builder.Property(p => p.IdFatherMenu).HasMaxLength(11);
    }
}
