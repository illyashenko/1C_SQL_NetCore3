using Microsoft.AspNetCore.Mvc;

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
