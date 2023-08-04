using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaVentas.Domain.Entities;

namespace SistemaVentas.Persistence.Configuration;
public class ProductConfig : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable(nameof(Product));
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Name).HasMaxLength(300);
        builder.Property(p => p.Barcode).HasMaxLength(300);
        builder.Property(p => p.Brand).HasMaxLength(300);
        builder.Property(p => p.Description).HasMaxLength(300);
        builder.Property(p => p.Stock).HasColumnType("int");
        builder.Property(p => p.UrlImage).HasMaxLength(500);
        builder.Property(p => p.ImagenName).HasMaxLength(300);
        builder.Property(p => p.Price).HasColumnType("float");
        builder.Property(p => p.IsActive).HasColumnType("bit");
        builder.HasOne(p => p.IdProductCategoryNavigation).WithMany(p => p.Products).HasForeignKey(p => p.IdCategory).HasPrincipalKey(p => p.Id);
    }
}
