using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BotPlatform.ExchangeLayer;

namespace BotPlatform.Controllers
{
    //[Produces("application/json")]
    [Route("api/Kunapublic")]
    public class KunapublicController : Controller
    {
        // GET: api/Kunapublic/5
        [HttpGet("{pair}", Name = "Get")]
        public string Get(string pair)
        {
            return KunaLogic.GetCurrency(pair);
        }
        
        // GET: api/Kunapublic
        [HttpGet]
        public void Get()
        {
        }
    }
}
