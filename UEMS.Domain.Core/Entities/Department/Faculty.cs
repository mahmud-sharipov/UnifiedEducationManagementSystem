using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UEMS.Domain.Core.Entities
{
    public class Faculty : EntityBase
    {
        public Faculty() : base() { }

        public string Name { get; set; }

        public virtual Worker Head { get; set; }

        public virtual Worker DeputyHead { get; set; }

        public virtual ISet<Department> Departments { get; set; }

        public override void InitializeAssociatedProperties()
        {

        }
    }
}
