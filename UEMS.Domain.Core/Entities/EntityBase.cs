using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UEMS.Domain.Core.Interfaces;

namespace UEMS.Domain.Core.Entities
{
    public abstract class EntityBase : IEntity
    {
        public EntityBase()
        {
            this.InitializeAssociatedProperties();
        }

        Guid guid;
        public Guid Guid
        {
            get => (guid == Guid.Empty ? guid = Guid.NewGuid() : guid);
            set => this.guid = value;
        }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }

        public virtual string Title { get; }

        public abstract void InitializeAssociatedProperties();
    }
}
