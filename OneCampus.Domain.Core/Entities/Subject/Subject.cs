using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneCampus.Domain.Core.Entities
{
    public class Subject : EntityBase
    {
        public Subject() : base() { }

        public string Name { get; set; }
        public string Code { get; set; }

        public virtual ISet<Schedule> Schedules { get; set; }
        public virtual ISet<TeacherSubject> Teachers { get; set; }

        public override void InitializeAssociatedProperties()
        {
            Schedules = new HashSet<Schedule>();
            Teachers = new HashSet<TeacherSubject>();
        }
    }
}
