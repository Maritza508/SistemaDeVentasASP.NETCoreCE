using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaVentas.Domain.Entities;

namespace SistemaVentas.Persistence.Configuration;
public class TypeDocumentVendingConfig : IEntityTypeConfiguration<TypeDocumentVending>
{
    public void Configure(EntityTypeBuilder<TypeDocumentVending> builder)
    {
        builder.ToTable(nameof(TypeDocumentVending));
        builder.HasKey(e => e.Id);
        builder.Property(p => p.Name).HasMaxLength(300);
        builder.Property(p => p.IsActive).HasColumnType("bit");
    }
}
