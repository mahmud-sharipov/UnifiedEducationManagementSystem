using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UEMS.Domain.Core.Entities
{
    public class ScheduleTemplateDetail : EntityBase
    {
        public ScheduleTemplateDetail() : base() { }

        public uint Order { get; set; }

        public virtual ExamType ExamType { get; set; }
        public virtual ScheduleTemplate ScheduleTemplate { get; set; }

        public override void InitializeAssociatedProperties() { }
    }
}
