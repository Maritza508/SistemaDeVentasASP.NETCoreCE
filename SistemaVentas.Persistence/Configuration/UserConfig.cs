using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaVentas.Domain.Entities;

namespace SistemaVentas.Persistence.Configuration;
public class UserConfig : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable(nameof(User));
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Name).HasMaxLength(300);
        builder.Property(p => p.Email).HasMaxLength(300);
        builder.Property(p => p.PhoneNumber).HasMaxLength(300);
        builder.Property(p => p.Password).HasMaxLength(300);
        builder.Property(p => p.UrlPhoto).HasMaxLength(300);
        builder.Property(p => p.NamePhoto).HasMaxLength(300);
        builder.Property(p => p.IsActive).HasColumnType("bit");
        builder.HasOne(p => p.IdRoleNavigation).WithMany(p => p.Users).HasForeignKey(p => p.IdRole).HasPrincipalKey(p => p.Id);

    }
}
