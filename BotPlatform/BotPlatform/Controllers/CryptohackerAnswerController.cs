using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BotPlatform.Cryptohacker;
using Microsoft.AspNetCore.Mvc;

namespace BotPlatform.Controllers
{
    [Route("api/[controller]")]
    public class CryptohackerAnswerController : Controller
    {
        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(string id)
        {
            ChatAnswer answer = new ChatAnswer();
            return answer.GetGenderAnswer(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
    }
}
