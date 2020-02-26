using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneCampus.Domain.Core.Entities
{
    public class Faculty : EntityBase
    {
        public Faculty() : base() { }

        public string Name { get; set; }

        public Guid HeadGuid { get; set; }
        public virtual Worker Head { get; set; }

        public Guid DeputyHeadGuid { get; set; }
        public virtual Worker DeputyHead { get; set; }

        public virtual ISet<Department> Departments { get; set; }

        public override void InitializeAssociatedProperties()
        {
            Departments = new HashSet<Department>();
        }
    }
}
