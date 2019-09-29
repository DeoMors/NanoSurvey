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
    public class SurveysController : ControllerBase
    {
        private NanoSurveyDbContext _context;

        public SurveysController(NanoSurveyDbContext context)
        {
            _context = context;
        }

        // GET: api/<controller>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Survey>>> Get()
        {
            return await _context.Surveys
                .AsNoTracking()
                .ToListAsync();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Survey>> Get(int id)
        {
            var survey = await _context.Surveys.FindAsync(id);
            if (survey == null)
            {
                return NotFound();
            }

            return survey;
        }
    }
}
