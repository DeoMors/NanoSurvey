using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NanoSurvey.Data;
using NanoSurvey.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NanoSurvey.Controllers
{
    [Route("api/[controller]")]
    public class InterviewController : ControllerBase
    {
        private NanoSurveyDbContext _context;

        public InterviewController(NanoSurveyDbContext context)
        {
            _context = context;
        }

        // POST api/<controller>
        [HttpPost]
        public async Task Post([FromBody]Interview interview)
        {
            if (interview == null)
            {
                return;
            }

            _context.Interviews.Add(interview);
            await _context.SaveChangesAsync();
        }
    }
}
