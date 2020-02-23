using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UEMS.Domain.Core.Entities
{
    public class GroupSchedule : EntityBase
    {
        public GroupSchedule() : base() { }

        public virtual Group Group { get; set; }
        public virtual Schedule Details { get; set; }

        public override void InitializeAssociatedProperties() { }
    }
}
