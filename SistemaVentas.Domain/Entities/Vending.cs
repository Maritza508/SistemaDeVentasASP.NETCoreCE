using SistemaVentas.Domain.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.Domain.Entities
{
    public class Vending : AuditableBaseEntity
    {
        public string VendingNumber { get; set; }
        public string ClientDocument { get; set; }
        public string ClientName { get; set; }
        public int Subtotal { get; set; }
        public int TotalTax { get; set; }
        public int Total { get; set; }
        public int IdUser { get; set; }
        public int IdTypeDocumentVending { get; set; }
        public virtual User? IdUserNavigation { get; set; }
        public virtual TypeDocumentVending? IdTypeDocumentVendingNavigation { get; set; }
        public virtual ICollection<VendingDetail> VendingDetail { get; } = new List<VendingDetail>();

    }
}
