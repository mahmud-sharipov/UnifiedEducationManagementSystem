using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UEMS.Domain.Core.Entities
{
    public class JournalDetail : EntityBase
    {
        public JournalDetail() : base() { }

        public DateTime Date { get; set; }
        public uint Score { get; set; }
        public uint AbsentHours { get; set; }

        public virtual Journal Journal { get; set; }
        public virtual StudentGroup StudentGroup { get; set; }
        public virtual ScheduleTemplateDetail TemplateDetail { get; set; }

        public override void InitializeAssociatedProperties() { }
    }
}
