using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UEMS.Domain.Core.Entities
{
    public class Student : Account
    {
        public Student() : base() { }

        public StudentStatus Status { get; set; }
    }

    public enum SubjectKnowledgeLevel
    {
        Beginner,
        Elementary,
        Intermediate,
        Advanced,
        Expert
    }
}
