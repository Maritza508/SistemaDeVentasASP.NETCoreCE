using SistemaVentas.Domain.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.Domain.Entities
{
    public class Menu : AuditableBaseEntity
    {
        public string Descriptions { get; set; }
        public string Icon { get; set; }
        public string Controller { get; set; }
        public string Pagination { get; set; }
        public bool IsActive { get; set; }
        public int IdFatherMenu { get; set; }
        public virtual ICollection<RoleMenu> MenuRoleMenus { get; } = new List<RoleMenu>();
    }
}
