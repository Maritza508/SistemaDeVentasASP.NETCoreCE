using SistemaVentas.Domain.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.Domain.Entities
{
    public class ConfigurationCE : AuditableBaseEntity
    {
        public string Resource { get; set; }
        public string Property { get; set; }
        public string Value { get; set; }    
    }
}
 