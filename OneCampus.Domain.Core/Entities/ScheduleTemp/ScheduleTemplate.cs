﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneCampus.Domain.Core.Entities
{
    public class ScheduleTemplate : EntityBase
    {
        public ScheduleTemplate() : base() { }

        public string Name { get; set; }
        public string Description { get; set; }
        public bool HasDailyScore { get; set; }
        public bool HasFinalExam { get; set; }

        public virtual ISet<ScheduleTemplateDetail> Details { get; set; }
        public virtual ISet<Schedule> Schedules { get; set; }

        public override void InitializeAssociatedProperties()
        {
            Details = new HashSet<ScheduleTemplateDetail>();
            Schedules = new HashSet<Schedule>();
        }
    }
}
