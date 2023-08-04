using SistemaVentas.Domain.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.Domain.Entities
{
    public class CorrelativeNumber : AuditableBaseEntity
    {
        public int LastNumber { get; set; }
        public int QuantityDigits { get; set; }
        public string Management { get; set; }
    }
}
