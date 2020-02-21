using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UEMS.Domain.Core.Entities
{
    public class Group : EntityBase
    {
        public Group() : base() { }

        public GroupStatus Status { get; set; }

        public string GroupBranch { get; set; }

        public virtual Language EducationLanguage { get; set; }

        public virtual GroupType Type { get; set; }

        public virtual Profession Profession { get; set; }

        public override void InitializeAssociatedProperties() { }
    }

    public enum GroupStatus
    {
        Closed = 0,
        Active = 1,
        Disbanded = 2,
    }
}
