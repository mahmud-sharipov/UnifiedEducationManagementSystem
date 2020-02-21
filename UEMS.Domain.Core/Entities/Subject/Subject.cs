using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UEMS.Domain.Core.Entities
{
    public class Subject : EntityBase
    {
        public Subject() : base() { }

        public string Name { get; set; }

        public string Code { get; set; }

        public override void InitializeAssociatedProperties()
        {

        }
    }
}
