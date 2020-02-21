using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UEMS.Domain.Core.Entities
{
    public class Language : EntityBase
    {
        public Language() : base() { }

        public string Name { get; set; }

        public string Key { get; set; }

        public virtual ISet<Group> Groups { get; set; }

        public override void InitializeAssociatedProperties()
        {

        }
    }
}
