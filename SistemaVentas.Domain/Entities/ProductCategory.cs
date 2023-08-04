using SistemaVentas.Domain.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.Domain.Entities
{
    public class ProductCategory : AuditableBaseEntity
    {
        public string Name { get; set; }    
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<Product> Products { get; } = new List<Product>();

    }
}
