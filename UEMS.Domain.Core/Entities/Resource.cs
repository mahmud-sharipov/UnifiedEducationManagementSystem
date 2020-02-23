using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UEMS.Domain.Core.Entities
{
    public class Resource : EntityBase
    {
        public Resource() : base() { }

        public string Name { get; set; }
        public string Description { get; set; }
        public string RecourcePath { get; set; }
        public ResourceType Type { get; set; }

        public virtual User UploadUser { get; set; }

        public override void InitializeAssociatedProperties() { }
    }
}
