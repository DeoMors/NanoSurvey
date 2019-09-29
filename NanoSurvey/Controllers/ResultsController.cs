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
    public class ResultsController : ControllerBase
    {
        private NanoSurveyDbContext _context;

        public ResultsController(NanoSurveyDbContext context)
        {
            _context = context;
        }
        
        // POST api/<controller>
        [HttpPost]
        public async Task Post([FromBody]PostedResult postedResult)
        {
            if (postedResult == null || postedResult.AnswerId?.Count == 0)
            {
                return;
            }

            var results = postedResult.AnswerId
                .Select(id => new Result { AnswerId = id, InterviewId = postedResult.InterviewId })
                .ToList();
            _context.Results.AddRange(results);
            await _context.SaveChangesAsync();
        }
    }
}
