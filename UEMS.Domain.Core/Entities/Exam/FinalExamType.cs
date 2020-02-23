using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UEMS.Domain.Core.Entities
{
    public class FinalExamType : ExamType
    {
        public FinalExamType() : base() { }

        public ExaminerType Examiner { get; set; }
    }
}
