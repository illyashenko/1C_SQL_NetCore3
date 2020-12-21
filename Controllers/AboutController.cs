using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ForOneCSQLAppNC3.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        // GET: About/<AboutController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

    }
}
