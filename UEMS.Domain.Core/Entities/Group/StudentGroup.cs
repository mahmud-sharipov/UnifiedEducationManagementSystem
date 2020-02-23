using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UEMS.Domain.Core.Entities
{
    public class StudentGroup : EntityBase
    {
        public StudentGroup() : base() { }

        public StudentGroupStatus Status { get; set; }

        public Guid StudentGuid { get; set; }
        public virtual Student Student { get; set; }

        public Guid GroupGuid { get; set; }
        public virtual Group Group { get; set; }

        public virtual ISet<JournalDetail> JournalDetails { get; set; }

        public override void InitializeAssociatedProperties()
        {
            JournalDetails = new HashSet<JournalDetail>();
        }
    }
}
