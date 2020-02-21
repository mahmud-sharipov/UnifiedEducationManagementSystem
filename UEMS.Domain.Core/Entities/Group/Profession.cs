using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UEMS.Domain.Core.Entities
{
    public class Profession : EntityBase
    {
        public Profession() : base() { }

        public string Name { get; set; }

        public string Code { get; set; }

        public virtual Department Department { get; set; }

        public virtual ISet<Group> Groups { get; set; }

        public override void InitializeAssociatedProperties()
        {
        }
    }
}
