using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UEMS.Domain.Core.Entities
{
    public class TeacherDepartment : EntityBase
    {
        public TeacherDepartment() : base() { }

        public TeacherDepartmentStatus Status { get; set; }

        public Guid TeacherGuid { get; set; }
        public virtual Teacher Teacher { get; set; }

        public Guid DepartmentGuid { get; set; }
        public virtual Department Department { get; set; }

        public override void InitializeAssociatedProperties() { }
    }
}
