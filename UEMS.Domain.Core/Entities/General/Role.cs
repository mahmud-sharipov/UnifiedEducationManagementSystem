using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UEMS.Domain.Core.Entities
{
    public class Role : EntityBase
    {
        public Role() : base() { }
        public string Name { get; set; }

        public virtual ISet<UserRole> UserRoles { get; set; }

        public override void InitializeAssociatedProperties()
        {
            UserRoles = new HashSet<UserRole>();
        }
    }
}
