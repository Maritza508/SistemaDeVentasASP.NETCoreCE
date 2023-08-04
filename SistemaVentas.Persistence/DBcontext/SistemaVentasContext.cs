using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SistemaVentas.Domain.BaseEntity;
using SistemaVentas.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.Persistence.DBcontext
{
    public class SistemaVentasContext : DbContext 
    {
        public SistemaVentasContext(DbContextOptions<SistemaVentasContext> options) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public virtual DbSet<Business> Businesses { get; set; }
        public virtual DbSet<ConfigurationCE> ConfigurationCEs { get; set; }    
        public virtual DbSet<CorrelativeNumber> CorrelativeNumbers { get; set;  }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductCategory> ProductCategories { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<RoleMenu> RoleMenus { get; set; }
        public virtual DbSet<TypeDocumentVending> TypeDocumentVendings { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Vending> Vendings { get; set; }
        public virtual DbSet<VendingDetail> VendingDetails { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableBaseEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedDate = DateTime.Now;
                        entry.Entity.CreatedBy = "admin ";
                        break;
                    case EntityState.Modified:
                        entry.Entity.LastModifiedDate = DateTime.Now;
                        entry.Entity.LastModifiedBy = "admin";
                        break;
                    default:
                        break;
                }
            }
            return base.SaveChangesAsync();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
