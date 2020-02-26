using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneCampus.Domain.Core.Entities
{
    public class WorkerPosition : EntityBase
    {
        public WorkerPosition() : base() { }

        public string Department { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Guid WorkerGuid { get; set; }
        public Worker Worker { get; set; }

        public Guid PositionGuid { get; set; }
        public Position Position { get; set; }

        public override void InitializeAssociatedProperties() { }
    }
}
