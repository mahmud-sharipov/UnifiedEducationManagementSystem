using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneCampus.Domain.Core.Entities
{
    public class ScheduleTemplateDetail : EntityBase
    {
        public ScheduleTemplateDetail() : base() { }

        public uint Order { get; set; }

        public Guid ExamTypeGuid { get; set; }
        public virtual ExamType ExamType { get; set; }
        public Guid TemplateGuid { get; set; }
        public virtual ScheduleTemplate Template { get; set; }

        public virtual ISet<JournalDetail> JournalDetails { get; set; }

        public override void InitializeAssociatedProperties()
        {
            JournalDetails = new HashSet<JournalDetail>();
        }
    }
}
