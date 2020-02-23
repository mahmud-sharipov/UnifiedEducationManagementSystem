using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UEMS.Domain.Core.Entities
{
    public class ClassDayScheduleTemplate : ScheduleTemplateDetail
    {
        public ClassDayScheduleTemplate() : base() { }

        public bool HasExam { get; set; }
    }
}
