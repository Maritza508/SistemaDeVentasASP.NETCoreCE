using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaVentas.Domain.Entities;

namespace SistemaVentas.Persistence.Configuration;
public class ProductCategoryConfig : IEntityTypeConfiguration<ProductCategory>
{
    public void Configure(EntityTypeBuilder<ProductCategory> builder)
    {
        builder.ToTable("ProductCategory");
        builder.HasKey(e => e.Id);
        builder.Property(p => p.Name).HasMaxLength(300);
        builder.Property(p => p.Description).HasMaxLength(300);
        builder.Property(p => p.IsActive).HasMaxLength(6);
    }
}
