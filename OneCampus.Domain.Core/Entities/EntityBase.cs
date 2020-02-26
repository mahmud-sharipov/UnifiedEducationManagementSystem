using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OneCampus.Domain.Core.Interfaces;

namespace OneCampus.Domain.Core.Entities
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

        public abstract void InitializeAssociatedProperties();
    }
}
