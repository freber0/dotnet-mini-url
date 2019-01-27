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
        private ServiceLocator serviceLocator = new ServiceLocator();

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }
       
        [HttpPost]
        public string UrlPostMethod([FromBody] PostUrlMethod value)
        {
            MiniUrlService service = serviceLocator.GetInstance();
            string shortGuid = service.ShrinkUrl(value.url);
            return shortGuid;
        }
    }
}
