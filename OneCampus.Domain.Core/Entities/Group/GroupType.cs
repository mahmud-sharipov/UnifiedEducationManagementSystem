using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneCampus.Domain.Core.Entities
{
    public class GroupType : EntityBase
    {
        public GroupType() : base() { }

        public string Name { get; set; }
        public string Desription { get; set; }

        public virtual ISet<Group> Groups { get; set; }

        public override void InitializeAssociatedProperties()
        {
            Groups = new HashSet<Group>();
        }
    }
}
