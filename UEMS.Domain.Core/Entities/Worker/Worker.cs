using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UEMS.Domain.Core.Entities
{
    public class Worker : Account
    {
        public Worker() : base() { }

        public virtual Teacher Teacher { get; set; }

        public virtual ISet<WorkerPosition> Positions { get; set; }

        public override void InitializeAssociatedProperties()
        {
            base.InitializeAssociatedProperties();
            Positions = new HashSet<WorkerPosition>();
        }
    }
}
