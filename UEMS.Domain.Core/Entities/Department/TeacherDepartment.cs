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

        public virtual Teacher Teacher { get; set; }

        public virtual Department Department { get; set; }

        public TeacherDepartmentStatus Status { get; set; }

        public override void InitializeAssociatedProperties()
        {

        }
    }

    public enum TeacherDepartmentStatus
    {
        Previous = 0,
        Current = 1
    }
}
