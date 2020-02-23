using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UEMS.Domain.Core.Entities
{
    public class ExamScheduleTemplate : ScheduleTemplateDetail
    {

        public ExamScheduleTemplate() : base() { }

        public ExaminerType ExaminerType { get; set; }
    }
}
