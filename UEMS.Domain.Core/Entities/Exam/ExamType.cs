using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UEMS.Domain.Core.Entities
{
    public class ExamType : EntityBase
    {
        public ExamType() : base() { }

        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Multiplier { get; set; }

        public override void InitializeAssociatedProperties() { }
    }
}
