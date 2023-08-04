using SistemaVentas.Domain.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.Domain.Entities
{
    public class TypeDocumentVending : AuditableBaseEntity
    {
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<Vending> Vendings { get; } = new List<Vending>();

    }
}
