﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UEMS.Domain.Core.Entities
{
    public class StudentExam : EntityBase
    {
        public StudentExam() : base() { }

        public virtual Exam Exam { get; set; }
        public virtual Student Student { get; set; }


        public override void InitializeAssociatedProperties() { }
    }
}
