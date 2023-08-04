using SistemaVentas.Domain.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.Domain.Entities
{
    public class VendingDetail : AuditableBaseEntity
    {
        public int IdProduct { get; set; }
        public string ProductBrand { get; set; }
        public string ProductDescription { get; set; }
        public string ProductCategory { get; set; }
        public int Amount { get; set; }
        public int Price { get; set; }
        public int Total { get; set; }
        public int IdVending { get; set; }
        public virtual Vending IdVendingNavigation { get; set; }
    }
}


