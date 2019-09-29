using Microsoft.EntityFrameworkCore;
using NanoSurvey.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NanoSurvey.Data
{
    public class NanoSurveyDbContext : DbContext
    {
        public NanoSurveyDbContext(DbContextOptions<NanoSurveyDbContext> options)
            : base(options)
        { }

        public DbSet<Answer> Answers { get; set; }

        public DbSet<Interview> Interviews { get; set; }

        public DbSet<Question> Questions { get; set; }

        public DbSet<Result> Results { get; set; }

        public DbSet<Survey> Surveys { get; set; }

        public DbSet<QuestionType> QuestionTypes { get; set; }
    }
}
