using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaVentas.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.Persistence.Configuration
{
    public class BusinessConfig : IEntityTypeConfiguration<Business>
    {
        public void Configure(EntityTypeBuilder<Business> builder)
        {
            builder.HasKey(e => e.Id);
            builder.ToTable("Business");
            builder.Property(p => p.UrlLogo).HasMaxLength(300);
            builder.Property(p => p.NameLogo).HasMaxLength(300);
            builder.Property(p => p.DocumentNumber).HasMaxLength(300);
            builder.Property(p => p.Name).HasMaxLength(300);
            builder.Property(p => p.Email).HasMaxLength(300);
            builder.Property(p => p.Direction).HasMaxLength(300);
            builder.Property(p => p.PhoneNumber).HasMaxLength(20);
            builder.Property(p => p.TaxRate).HasMaxLength(300);
            builder.Property(p => p.CurrencySymbol).HasMaxLength(300);
        }
    }
}
