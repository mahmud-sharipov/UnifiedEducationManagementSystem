using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UEMS.Domain.Core.Entities
{
    public class Position : EntityBase
    {
        public Position() : base() { }

        public string Name { get; set; }

        public virtual ISet<WorkerPosition> Workers { get; set; }

        public override void InitializeAssociatedProperties()
        {

        }
    }
}
