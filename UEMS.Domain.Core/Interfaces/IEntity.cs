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
        
        string Title { get; }
     
        DateTime CreatedDate { get; set; }

        DateTime UpdatedDate { get; set; }
    }
}
