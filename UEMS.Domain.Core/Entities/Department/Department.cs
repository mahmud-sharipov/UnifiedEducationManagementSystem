using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UEMS.Domain.Core.Entities
{
    public class Department : EntityBase
    {
        public Department() : base() { }

        public string Name { get; set; }

        public Faculty Faculty { get; set; }

        public virtual Worker Head { get; set; }

        public virtual Worker DeputyHead { get; set; }

        public virtual ISet<Profession> Professions { get; set; }

        public override void InitializeAssociatedProperties()
        {
        }
    }

}
