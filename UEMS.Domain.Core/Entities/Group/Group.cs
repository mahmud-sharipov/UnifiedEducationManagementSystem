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

        public virtual Language EducationLanguage { get; set; }

        public virtual GroupType Type { get; set; }

        public virtual Profession Profession { get; set; }

        public override void InitializeAssociatedProperties() { }
    }
}
