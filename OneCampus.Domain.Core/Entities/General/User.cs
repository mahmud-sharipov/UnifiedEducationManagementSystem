using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneCampus.Domain.Core.Entities
{
    public class User : EntityBase
    {
        public User() : base() { }

        public string Username { get; set; }
        public int Email { get; set; }
        public int Password { get; set; }
        public string Avatar { get; set; }
        public bool IsActive { get; set; }

        public virtual ISet<UserRole> UserRoles { get; set; }
        public virtual ISet<Resource> UploadFiles { get; set; }

        public override void InitializeAssociatedProperties()
        {
            UserRoles = new HashSet<UserRole>();
            UploadFiles = new HashSet<Resource>();
        }
    }
}
