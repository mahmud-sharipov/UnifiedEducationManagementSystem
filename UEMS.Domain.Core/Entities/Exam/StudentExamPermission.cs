using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UEMS.Domain.Core.Entities
{
    public class StudentExamPermission : EntityBase
    {
        public StudentExamPermission() : base() { }

        public Guid StudentGuid { get; set; }
        public virtual Student Student { get; set; }

        public Guid ExamGuid { get; set; }
        public virtual Exam Exam { get; set; }

        public override void InitializeAssociatedProperties() { }

    }
}
