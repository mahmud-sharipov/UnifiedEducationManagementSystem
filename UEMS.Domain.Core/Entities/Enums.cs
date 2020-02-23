using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UEMS.Domain.Core.Entities
{
    public enum TeacherDepartmentStatus
    {
        Previous = 0,
        Current = 1
    }

    public enum Gender
    {
        Male,
        Fimail
    }

    public enum GroupStatus
    {
        Closed = 0,
        Active = 1,
        Disbanded = 2,
    }

    public enum StudentGroupStatus
    {
        Current,
        Previous
    }

    public enum ResourceType
    {
        Document,
        Image,
        Video,
        Audio,
        Text
    }

    public enum ScheduleStatus
    {
        NotSarted,
        InProgress,
        Examination,
        Completed,
    }

    public enum StudentStatus
    {
        Active,
        Alumnus,
        AcademicLeave,
        Expelled
    }

    public enum ExaminerType
    {
        TestCenter,
        Teacher
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
