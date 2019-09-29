using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NanoSurvey.Models
{
    public class Survey
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        [JsonIgnore]
        public ICollection<Question> Questions { get; set; }
    }
}
