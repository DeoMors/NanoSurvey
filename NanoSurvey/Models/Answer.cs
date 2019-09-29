using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NanoSurvey.Models
{
    public class Answer
    {
        public int Id { get; set; }

        [JsonIgnore]
        [Column("question_id")]
        public int QuestionId { get; set; }

        [JsonIgnore]
        public Question Question { get; set; }

        public string Text { get; set; }
    }
}
