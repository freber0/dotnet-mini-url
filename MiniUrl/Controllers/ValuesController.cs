using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MiniUrl.Controllers
{
    [Route("/")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }
       
        [HttpPost]
        public JsonResult UrlPostMethod([FromBody] PostUrlMethod value)
        {
            return new JsonResult(value);
        }
    }
}
