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

        public virtual Schedule Schedule { get; set; }

        public virtual FinalExamType Type { get; set; }

        public virtual ISet<StudentExam> StudentExams { get; set; }

        public override void InitializeAssociatedProperties() { }
    }
}
