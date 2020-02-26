using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneCampus.Domain.Core.Entities
{
    public class Teacher : EntityBase
    {
        public Teacher() : base() { }

        public virtual Department DepartmentIamHeadFor { get; set; }
        public virtual Department DepartmentIamDeputyHeadFor { get; set; }
        public virtual Faculty FacultyIamHeadFor { get; set; }
        public virtual Faculty FacultyIamDeputyHeadFor { get; set; }

        public Guid WorkerGuid { get; set; }
        public virtual Worker Worker { get; set; }

        public virtual ISet<TeacherDepartment> Departments { get; set; }
        public virtual ISet<Schedule> Schedules { get; set; }
        public virtual ISet<TeacherSubject> Subjects { get; set; }

        public override void InitializeAssociatedProperties()
        {
            Departments = new HashSet<TeacherDepartment>();
            Schedules = new HashSet<Schedule>();
            Subjects = new HashSet<TeacherSubject>();
        }
    }
}
