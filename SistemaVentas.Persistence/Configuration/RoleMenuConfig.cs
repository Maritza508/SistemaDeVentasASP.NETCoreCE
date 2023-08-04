using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaVentas.Domain.Entities;

namespace SistemaVentas.Persistence.Configuration;
public class RoleMenuConfig : IEntityTypeConfiguration<RoleMenu>
{
    public void Configure(EntityTypeBuilder<RoleMenu> builder)
    {
        builder.ToTable(nameof(RoleMenu));
        builder.HasKey(e => e.Id);
        builder.Property(p => p.IsActive).HasMaxLength(20);
        builder.HasOne(p => p.IdRoleNavigation).WithMany(p => p.RoleMenus).HasForeignKey(p => p.IdRole).HasPrincipalKey(p => p.Id);
        builder.HasOne(p => p.IdMenuNavigation).WithMany(p => p.MenuRoleMenus).HasForeignKey(p => p.IdMenu).HasPrincipalKey(p => p.Id);
    }
}
