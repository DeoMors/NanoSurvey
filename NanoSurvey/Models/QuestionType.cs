using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NanoSurvey.Models
{
    [Table("question_types")]
    public class QuestionType
    {
        public int Id { get; set; }

        public string Description { get; set; }
    }
}
