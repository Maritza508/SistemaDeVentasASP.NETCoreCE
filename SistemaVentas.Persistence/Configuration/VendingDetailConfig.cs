using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaVentas.Domain.Entities;

namespace SistemaVentas.Persistence.Configuration;
public class VendingDetailConfig : IEntityTypeConfiguration<VendingDetail>
{
    public void Configure(EntityTypeBuilder<VendingDetail> builder)
    {
       builder.ToTable(nameof(VendingDetail));
       builder.HasKey(x => x.Id);
       builder.Property(p => p.IdProduct).HasColumnType("float");
       builder.Property(p => p.ProductBrand).HasMaxLength(300);
       builder.Property(p => p.ProductDescription).HasMaxLength(300);
       builder.Property(p => p.ProductCategory).HasMaxLength(300);
       builder.Property(p => p.Amount).HasColumnType("float");
       builder.Property(p => p.Price).HasColumnType("float");
       builder.Property(p => p.Total).HasColumnType("float");
       builder.HasOne(p => p.IdVendingNavigation).WithMany(p => p.VendingDetail).HasForeignKey(p => p.IdVending).HasPrincipalKey(p => p.Id);
    }
}
