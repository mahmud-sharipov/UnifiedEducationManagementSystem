using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneCampus.Domain.Core.Entities
{
    public class GroupSchedule : EntityBase
    {
        public GroupSchedule() : base() { }

        public Guid GroupGuid { get; set; }
        public virtual Group Group { get; set; }

        public Guid ScheduleGuid { get; set; }
        public virtual Schedule Schedule { get; set; }

        public override void InitializeAssociatedProperties() { }
    }
}
