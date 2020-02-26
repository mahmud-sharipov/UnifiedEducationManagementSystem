using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneCampus.Domain.Core.Entities
{
    public class FinalExamType : ExamType
    {
        public FinalExamType() : base() { }

        public ExaminerType ExaminerType { get; set; }

        public virtual ISet<Exam> Exams { get; set; }

        public override void InitializeAssociatedProperties()
        {
            Exams = new HashSet<Exam>();
        }
    }
}
