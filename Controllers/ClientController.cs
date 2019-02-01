using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using POS.APIs.Data;

namespace POS.APIs.Controllers
{
    [AllowAnonymous]
    [Route("api/Client")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly GLPOSContext _context;
        private readonly ILogger<StateTaxController> _logger;

        public ClientController(GLPOSContext context, ILogger<StateTaxController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // GET: api/StateTax

        [HttpGet]
        [HttpGet("all", Name = "getClients")]
        public IActionResult All()
        {
            var clients = _context.Clients.Include(clt => clt.Client_Phones).Include(ct => ct.Client_Type).ToList();
            return Ok(clients);
            //return new JsonResult(questions.Adapt<QuestionViewModel[]>(), new JsonSerializerSettings() { Formatting = Formatting.Indented });
        }

 
    }
}
