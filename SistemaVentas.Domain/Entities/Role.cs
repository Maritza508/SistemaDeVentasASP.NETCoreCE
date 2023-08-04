using SistemaVentas.Domain.BaseEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.Domain.Entities
{
    public class Role : AuditableBaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<RoleMenu> RoleMenus { get; } = new List<RoleMenu>();
        public virtual ICollection<User> Users { get; } = new List<User>();


    }
}
