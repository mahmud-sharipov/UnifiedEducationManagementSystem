using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneCampus.Domain.Core.Entities
{
    public class GlobalSettings : BaseSettings
    {
        public GlobalSettings() : base() { }

        public bool IsSystemFullySetup { get; set; }

        public Guid CurrentStudyYearGuid { get; set; }
        public virtual StudyYear CurrentStudyYear { get; set; }

        public override void InitializeAssociatedProperties() { }
    }
}
