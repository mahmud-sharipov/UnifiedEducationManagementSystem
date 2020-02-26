using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneCampus.Domain.Core.Entities
{
    public class Department : EntityBase
    {
        public Department() : base() { }

        public string Name { get; set; }

        public Guid FacultyGuid { get; set; }
        public Faculty Faculty { get; set; }

        public Guid HeadGuid { get; set; }
        public virtual Teacher Head { get; set; }

        public Guid DeputyHeadGuid { get; set; }
        public virtual Teacher DeputyHead { get; set; }

        public virtual ISet<Profession> Professions { get; set; }
        public virtual ISet<TeacherDepartment> Teachers { get; set; }
        public override void InitializeAssociatedProperties()
        {
            Professions = new HashSet<Profession>();
            Teachers = new HashSet<TeacherDepartment>();
        }
    }

}
