using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NanoSurvey.Models
{
    public class Question
    {
        public int Id { get; set; }

        [JsonIgnore]
        [Column("survey_id")]
        public int SurveyId { get; set; }

        [JsonIgnore]
        public Survey Survey { get; set; }

        public string Text { get; set; }

        [JsonIgnore]
        [Column("question_type_id")]
        public int QuestionTypeId { get; set; }

        public QuestionType QuestionType { get; set; }

        [JsonIgnore]
        public ICollection<Answer> Answers { get; set; }
    }
}
