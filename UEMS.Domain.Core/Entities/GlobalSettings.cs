﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UEMS.Domain.Core.Entities
{
    public class GlobalSettings : BaseSettings
    {
        public GlobalSettings() : base() { }

        public virtual StudyYear CurrentStudyYear { get; set; }

        public override void InitializeAssociatedProperties() { }
    }
}
