using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneCampus.Domain.Core.Entities
{
    public class DailyJournalDetail : JournalDetail
    {
        public DailyJournalDetail() : base() { }

        public uint ExamScore { get; set; }
    }
}
