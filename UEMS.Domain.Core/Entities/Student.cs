using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UEMS.Domain.Core.Entities
{
    public class Student : Account
    {
        public Student() : base() { }

        public StudentStatus Status { get; set; }

        public virtual ISet<StudentExamPermission> ExamPermissions { get; set; }
        public virtual ISet<StudentExam> Exams { get; set; }
        public virtual ISet<StudentGroup> Groups { get; set; }
        public virtual ISet<StudentTranscript> Transcripts { get; set; }
        public virtual ISet<StudentElectiveSchedule> ElectiveSchedules { get; set; }
        public override void InitializeAssociatedProperties()
        {
            base.InitializeAssociatedProperties();
            ExamPermissions = new HashSet<StudentExamPermission>();
            Exams = new HashSet<StudentExam>();
            Groups = new HashSet<StudentGroup>();
            Transcripts = new HashSet<StudentTranscript>();
            ElectiveSchedules = new HashSet<StudentElectiveSchedule>();
        }
    }
}
