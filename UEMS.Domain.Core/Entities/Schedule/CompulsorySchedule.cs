using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UEMS.Domain.Core.Entities
{
    public class CompulsorySchedule : Schedule
    {
        public CompulsorySchedule() : base() { }

        public virtual Journal CourseWork { get; set; }
    }
}
