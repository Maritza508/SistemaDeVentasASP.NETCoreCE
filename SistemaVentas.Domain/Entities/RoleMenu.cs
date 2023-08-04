using SistemaVentas.Domain.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.Domain.Entities
{
    public class RoleMenu : AuditableBaseEntity
    {

        public int IdRole { get; set; }   
        public int IdMenu { get; set; }   
        public bool IsActive { get; set; }  
        public virtual Role? IdRoleNavigation { get; set; }
        public virtual Menu? IdMenuNavigation { get; set; }
    }
}
