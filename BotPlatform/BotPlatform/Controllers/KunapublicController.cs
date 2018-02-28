using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BotPlatform.ServerLogic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BotPlatform.Controllers
{
    [Produces("application/json")]
    [Route("api/Kunapublic")]
    public class KunapublicController : Controller
    {
         KunaHandler kunaHandler = new KunaHandler();

        // GET: api/Kunapublic/5
        [HttpGet]
        public string Get()
        {
            return kunaHandler.GetTimestamp();
        }
        
        // POST: api/Kunapublic
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
    }
}
