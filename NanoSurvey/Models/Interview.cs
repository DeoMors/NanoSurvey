using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NanoSurvey.Models
{
    public class Interview
    {
        public int Id { get; set; }

        [Column("survey_id")]
        public int ServeyId { get; set; }

        public Survey Survey { get; set; }

        public int? UserId { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }
    }
}
