using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UEMS.Domain.Core.Interfaces
{
    public interface IEntity
    {
        Guid Guid { get; }

        DateTime CreatedDate { get; }

        DateTime UpdatedDate { get; }
    }
}
