using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NanoSurvey.Models
{
    public class Result
    {
        public int Id { get; set; }

        [Column("interview_id")]
        public int InterviewId { get; set; }

        public Interview Interview { get; set; }

        [Column("answer_id")]
        public int AnswerId { get; set; }

        public Answer Answer { get; set; }
    }
}
