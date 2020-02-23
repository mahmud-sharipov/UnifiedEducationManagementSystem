using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UEMS.Domain.Core.Entities
{
    public class Journal : EntityBase
    {
        public Journal() : base() { }

        public virtual Schedule Schedule { get; set; }

        public virtual ISet<JournalDetail> Details { get; set; }

        public override void InitializeAssociatedProperties() { }
    }
}
