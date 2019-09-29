using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NanoSurvey.Models
{
    public class PostedResult
    {
        public int InterviewId { get; set; }

        public List<int> AnswerId { get; set; }
    }
}
