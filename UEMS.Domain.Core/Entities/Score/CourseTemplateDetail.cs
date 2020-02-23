using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UEMS.Domain.Core.Entities
{
    public class CourseTemplateDetail : EntityBase
    {
        public CourseTemplateDetail() : base() { }

        public uint Order { get; set; }

        public virtual CourseTemplate Template { get; set; }
        public virtual ExamType ExamType { get; set; }

        public override void InitializeAssociatedProperties() { }
    }
}
