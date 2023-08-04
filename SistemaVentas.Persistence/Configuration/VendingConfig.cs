using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaVentas.Domain.Entities;

namespace SistemaVentas.Persistence.Configuration;
public class VendingConfig : IEntityTypeConfiguration<Vending>
{
    public void Configure(EntityTypeBuilder<Vending> builder)
    {
        builder.ToTable(nameof(Vending));
        builder.HasKey(p => p.Id);
        builder.Property(p => p.VendingNumber).HasMaxLength(300);
        builder.Property(p => p.ClientDocument).HasMaxLength(300);
        builder.Property(p => p.ClientName).HasMaxLength(300);
        builder.Property(p => p.Subtotal).HasColumnType("float");
        builder.Property(p => p.TotalTax).HasColumnType("float");
        builder.Property(p => p.Total).HasColumnType("float");
        builder.HasOne(p => p.IdUserNavigation).WithMany(p => p.Vendings).HasForeignKey(p => p.IdUser).HasPrincipalKey(p => p.Id);
        builder.HasOne(p => p.IdTypeDocumentVendingNavigation ).WithMany(p => p.Vendings).HasForeignKey(p => p.IdTypeDocumentVending).HasPrincipalKey(p => p.Id);
    }
}
