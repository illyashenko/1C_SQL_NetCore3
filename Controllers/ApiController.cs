using Microsoft.AspNetCore.Mvc;
using ForOneCSQLAppNC3.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ForOneCSQLAppNC3.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        IServiceAPI ServiceAPI;

        public ApiController(IServiceAPI serviceAPI)
        {
            ServiceAPI = serviceAPI;
        }

        // POST api/<ApiController>
        [HttpPost]
        public IActionResult Post([FromBody] JSONParametrs req)
        {
            var returnList = ServiceAPI.GetData(req);
            if (returnList != null)
                return new ObjectResult(returnList);
            return BadRequest();
        }
    }
}
