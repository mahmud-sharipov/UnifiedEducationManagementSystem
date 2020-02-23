using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UEMS.Domain.Core.Entities
{
    public class Group : EntityBase
    {
        public Group() : base() { }

        public GroupStatus Status { get; set; }
        public char GroupKey { get; set; }
        public uint TotalStudyYears { get; set; }
        public uint CurrenStudyYear { get; set; }

        public Guid EducationLanguageGuid { get; set; }
        public virtual Language EducationLanguage { get; set; }

        public Guid TypeGuid { get; set; }
        public virtual GroupType Type { get; set; }

        public Guid ProfessionGuid { get; set; }
        public virtual Profession Profession { get; set; }

        public virtual ISet<StudentGroup> Students { get; set; }
        public virtual ISet<GroupSchedule> Schedules { get; set; }
        public override void InitializeAssociatedProperties()
        {
            Students = new HashSet<StudentGroup>();
            Schedules = new HashSet<GroupSchedule>();
        }
    }
}
