using SistemaVentas.Domain.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.Domain.Entities
{
    public class Business : AuditableBaseEntity
    {

        public string UrlLogo { get; set; }
        public string NameLogo { get; set; }
        public string DocumentNumber { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Direction { get; set; }
        public string PhoneNumber { get; set; }
        public float TaxRate { get; set; }
        public string CurrencySymbol { get; set; }
    }
}
