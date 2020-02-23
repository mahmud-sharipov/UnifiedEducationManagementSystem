using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UEMS.Domain.Core.Entities
{
    public abstract class Schedule : EntityBase
    {
        public Schedule() : base() { }

        public uint Semester { get; set; }
        public uint Sprint { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public uint TotalHoursInDay { get; set; }
        public bool OnMonday { get; set; }
        public bool OnTuesday { get; set; }
        public bool OnWednesday { get; set; }
        public bool OnThursday { get; set; }
        public bool OnFriday { get; set; }
        public bool OnSaturday { get; set; }
        public ScheduleStatus Status { get; set; }

        public virtual StudyYear StudyYear { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual ScheduleTemplate Template { get; set; }
        public virtual Journal Journal { get; set; }
        public virtual ISet<GroupSchedule> Groups { get; set; }
        public virtual ISet<CourseResource> Resources { get; set; }
        public override void InitializeAssociatedProperties() { }
    }
}
