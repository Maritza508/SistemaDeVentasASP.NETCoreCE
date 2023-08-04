using SistemaVentas.Domain.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.Domain.Entities
{
    public class Product : AuditableBaseEntity
    {
        public string Name { get; set; }
        public string Barcode { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public string UrlImage { get; set; }
        public string ImagenName { get; set; }
        public float Price { get; set; }
        public bool IsActive { get; set; }
        public int IdCategory { get; set; }
        public virtual ProductCategory IdProductCategoryNavigation { get; set; }
    }
}
