using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UEMS.Domain.Core.Entities
{
    public class StudentElectiveSchedule : EntityBase
    {
        public StudentElectiveSchedule() : base() { }

        public Guid StudentGuid { get; set; }
        public virtual Student Student { get; set; }

        public Guid ElectiveScheduleGuid { get; set; }
        public virtual ElectiveSchedule ElectiveSchedule { get; set; }

        public override void InitializeAssociatedProperties() { }
    }
}
