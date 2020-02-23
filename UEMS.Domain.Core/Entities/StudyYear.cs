using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UEMS.Domain.Core.Entities
{
    public class StudyYear : EntityBase
    {
        public StudyYear() : base() { }

        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndtDate { get; set; }

        public override void InitializeAssociatedProperties() { }
    }
}
