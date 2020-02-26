using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneCampus.Domain.Core.Entities
{
    public class StudentTranscript : EntityBase
    {
        public StudentTranscript() : base() { }

        public uint ExamScore { get; set; }
        public uint CourseScore { get; set; }
        public uint FinalScore { get; set; }
        public char ScoreLatter { get; set; }
        public uint TotalAbsentPercentage { get; set; }

        public Guid ScheduleGuid { get; set; }
        public virtual Schedule Schedule { get; set; }

        public Guid StudentGuid { get; set; }
        public virtual Student Student { get; set; }

        public override void InitializeAssociatedProperties() { }
    }
}
