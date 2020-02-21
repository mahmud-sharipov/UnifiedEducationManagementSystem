using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UEMS.Domain.Core.Entities
{
    public class StudentGroup : EntityBase
    {
        public StudentGroup() : base() { }

        public virtual Student Student { get; set; }

        public virtual Group Group { get; set; }

        public StudentGroupStatus Status { get; set; }

        public override void InitializeAssociatedProperties() { }
    }

    public enum StudentGroupStatus
    {
        Current,
        Previous
    }
}
