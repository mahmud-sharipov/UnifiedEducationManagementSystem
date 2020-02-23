using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UEMS.Domain.Core.Entities
{
    public class ScheduleTemplate : EntityBase
    {
        public ScheduleTemplate() : base() { }

        public string Name { get; set; }
        public string Description { get; set; }
        public bool HasDailyScore { get; set; }
        public bool HasFinalExam { get; set; }

        public virtual ISet<ScheduleTemplateDetail> Details { get; set; }

        public override void InitializeAssociatedProperties() { }
    }
}
