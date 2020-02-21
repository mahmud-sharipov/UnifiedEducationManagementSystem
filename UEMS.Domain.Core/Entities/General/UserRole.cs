using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UEMS.Domain.Core.Entities
{
    public class UserRole : EntityBase
    {
        public UserRole() : base() { }

        public virtual User User { get; set; }

        public virtual Role Role { get; set; }

        public override void InitializeAssociatedProperties() { }
    }
}
