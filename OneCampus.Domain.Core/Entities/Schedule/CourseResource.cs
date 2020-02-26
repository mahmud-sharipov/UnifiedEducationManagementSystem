using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneCampus.Domain.Core.Entities
{
    public class CourseResource : Resource
    {
        public CourseResource() : base() { }

        public Guid ScheduleGuid { get; set; }
        public virtual Schedule Schedule { get; set; }
    }

   
}
