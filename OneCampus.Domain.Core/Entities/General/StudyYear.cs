using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneCampus.Domain.Core.Entities
{
    public class StudyYear : EntityBase
    {
        public StudyYear() : base() { }

        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndtDate { get; set; }

        public virtual ISet<GlobalSettings> GlobalSettings { get; set; }
        public virtual ISet<Schedule> Schedules { get; set; }
        public override void InitializeAssociatedProperties()
        {
            GlobalSettings = new HashSet<GlobalSettings>();
            Schedules = new HashSet<Schedule>();

        }
    }
}
