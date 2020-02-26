using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneCampus.Domain.Core.Entities
{
    public abstract class ExamType : EntityBase
    {
        public ExamType() : base() { }

        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Multiplier { get; set; }

        public virtual ISet<ScheduleTemplate> ScheduleTemplates { get; set; }

        public override void InitializeAssociatedProperties()
        {
            ScheduleTemplates = new HashSet<ScheduleTemplate>();
        }
    }
}
