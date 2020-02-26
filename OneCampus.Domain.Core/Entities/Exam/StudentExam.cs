using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneCampus.Domain.Core.Entities
{
    public class StudentExam : EntityBase
    {
        public StudentExam() : base() { }

        public Guid ExamGuid { get; set; }
        public virtual Exam Exam { get; set; }

        public Guid StudentGuid { get; set; }
        public virtual Student Student { get; set; }

        public override void InitializeAssociatedProperties() { }
    }
}
