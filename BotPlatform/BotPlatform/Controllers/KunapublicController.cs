using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KunaService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BotPlatform.Controllers
{
    [Produces("application/json")]
    [Route("api/Kunapublic")]
    public class KunapublicController : Controller
    {
        KunaServiseClient kunaServise = new KunaServiseClient();

        // GET: api/Kunapublic/5
        [HttpGet]
        public string Get()
        {

            return "value";
        }
        
        // POST: api/Kunapublic
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
    }
}
