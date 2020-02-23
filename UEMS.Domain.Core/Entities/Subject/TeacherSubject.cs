using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UEMS.Domain.Core.Entities
{
    public class TeacherSubject : EntityBase
    {
        public TeacherSubject() : base() { }

        public SubjectKnowledgeLevel KnowledgeLevel { get; set; }

        public Guid SubjectGuid { get; set; }
        public virtual Subject Subject { get; set; }

        public Guid TeacherGuid { get; set; }
        public virtual Teacher Teacher { get; set; }

        public override void InitializeAssociatedProperties() { }
    }
}
