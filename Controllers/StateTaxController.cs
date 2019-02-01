using System;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using POS.APIs.Data;
using POS.APIs.Data.Models;

namespace POS.APIs.Controllers
{
    //[Authorize]
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class StateTaxController : ControllerBase
    {
        private readonly GLPOSContext _context;
        private readonly ILogger<StateTaxController> _logger;

        public StateTaxController(GLPOSContext context, ILogger<StateTaxController> logger)
        {
            _context = context;
            _logger = logger;
        }
        
        // GET: api/StateTax
        
        [HttpGet]
        [HttpGet("all", Name = "getStateTaxes")]
        public IActionResult All()
        {
            var statetaxes = _context.StateTaxes.ToList();
            return Ok(statetaxes);
            
            //return new JsonResult(questions.Adapt<QuestionViewModel[]>(), new JsonSerializerSettings() { Formatting = Formatting.Indented });
        }

        
        // GET: api/StateTax/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(string id)
        {
            var statetaxes = _context.StateTaxes.Where(st => st.StateTaxId == id).FirstOrDefault();
            if (statetaxes == null)
            {
                return NotFound(new { Error = String.Format("Record has not been found", id) });
            }
            return Ok(statetaxes);
        }

        // POST: api/StateTax
        [HttpPost]
        public IActionResult Post([FromBody] StateTax model)
        {

            if (model == null)
                return new StatusCodeResult(500);

            StateTax statetaxes = _context.StateTaxes.Where(st => st.StateTaxId == model.StateTaxId).FirstOrDefault();

            if (statetaxes != null)
            {
                return new BadRequestObjectResult("Record already exist");
            }

            statetaxes = new StateTax { StateTaxId = model.StateTaxId, TaxAmount = model.TaxAmount };

            _context.StateTaxes.Add(statetaxes);
            _context.SaveChanges();

            return Ok(statetaxes);
            
        }

        // PUT: api/StateTax/
        [HttpPut]
        public IActionResult Put([FromBody] StateTax model)
        {
            if (model == null)
                return new StatusCodeResult(500);

            var statetaxes = _context.StateTaxes.Where(st => st.StateTaxId == model.StateTaxId).FirstOrDefault();

            if (statetaxes == null)
            {
                return NotFound(new { Error = String.Format("Record has not been found", model.StateTaxId) });
            }


            statetaxes.TaxAmount = model.TaxAmount;

            _context.SaveChanges();

            return Ok(statetaxes);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            var statetaxes = _context.StateTaxes.Where(st => st.StateTaxId == id).FirstOrDefault();

            if (statetaxes == null)
            {
                return NotFound(new { Error = String.Format("Record {0} has not been found", id) });
            }

            _context.StateTaxes.Remove(statetaxes);
            _context.SaveChanges();

            return new OkResult();
        }



    }
}
