using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaVentas.Domain.Entities;

namespace SistemaVentas.Persistence.Configuration;
public class CorrelativeNumberConfig : IEntityTypeConfiguration<CorrelativeNumber>
{
    public void Configure(EntityTypeBuilder<CorrelativeNumber> builder)
    {
        builder.ToTable("CorrelativeNumber");
        builder.HasKey(p => p.Id);
        builder.Property(p => p.LastNumber).HasMaxLength(11);
        builder.Property(p => p.QuantityDigits).HasMaxLength(11);
        builder.Property(p => p.Management).HasMaxLength(300);
    }
}
