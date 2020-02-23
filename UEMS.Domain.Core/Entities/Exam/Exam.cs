using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UEMS.Domain.Core.Entities
{
    public class Exam : EntityBase
    {
        public Exam() : base() { }

        public Guid ScheduleGuid { get; set; }
        public virtual Schedule Schedule { get; set; }

        public Guid TypeGuid { get; set; }
        public virtual FinalExamType Type { get; set; }

        public virtual ISet<StudentExam> StudentExams { get; set; }
        public virtual ISet<StudentExamPermission> StudentPermissions { get; set; }

        public override void InitializeAssociatedProperties()
        {
            StudentExams = new HashSet<StudentExam>();
            StudentPermissions = new HashSet<StudentExamPermission>();
        }
    }
}
