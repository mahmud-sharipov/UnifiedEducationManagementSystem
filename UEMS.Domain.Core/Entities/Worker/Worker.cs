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

        public virtual ISet<WorkerPosition> Positions { get; set; }

        public virtual Position Position { get; set; }
    }
}
