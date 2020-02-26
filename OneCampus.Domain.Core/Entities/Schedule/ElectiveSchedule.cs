using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneCampus.Domain.Core.Entities
{
    public class ElectiveSchedule : Schedule
    {
        public ElectiveSchedule() : base() { }

        public virtual ISet<StudentElectiveSchedule> Students { get; set; }

        public override void InitializeAssociatedProperties()
        {
            base.InitializeAssociatedProperties();
            Students = new HashSet<StudentElectiveSchedule>();
        }
    }
}
