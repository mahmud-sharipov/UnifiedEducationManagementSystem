using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UEMS.Domain.Core.Entities
{
    public class Nationality : EntityBase
    {
        public Nationality() : base() { }

        public string Name { get; set; }

        public ISet<Account> Accounts { get; set; }

        public override void InitializeAssociatedProperties()
        {
            Accounts = new HashSet<Account>();
        }
    }
}
