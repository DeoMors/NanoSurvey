using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NanoSurvey.Data;
using NanoSurvey.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NanoSurvey.Controllers
{
    [Route("api/[controller]")]
    public class QuestionsController : ControllerBase
    {
        private NanoSurveyDbContext _context;

        public QuestionsController(NanoSurveyDbContext context)
        {
            _context = context;
        }

        // GET api/<controller>/5
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Question>>> GetQuestionsFromSurvey([FromBody]int surveyId)
        {
            var questions = await _context.Questions
                .Include(q => q.QuestionType)
                .Where(q => q.SurveyId == surveyId)
                .AsNoTracking()
                .ToListAsync();
            if (questions == null)
            {
                return NotFound();
            }

            return questions;
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Question>> Get(int id)
        {
            var question = await _context.Questions
                .Include(q => q.QuestionType)
                .AsNoTracking()
                .FirstOrDefaultAsync(q => q.Id == id);
            if (question == null)
            {
                return NotFound();
            }

            return question;
        }
    }
}
