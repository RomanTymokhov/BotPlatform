using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BotPlatform.Cryptohacker;
using BotPlatform.Responses;
using Microsoft.AspNetCore.Mvc;

namespace BotPlatform.Controllers
{
    [Route("api/[controller]")]
    public class CryptohackerAnswerController : Controller
    {
        [HttpGet]
        public string Get()
        {
            ChatAnswer answer = new ChatAnswer();

            string gender = Request.Query.FirstOrDefault(p => p.Key == "gender").Value;

            return answer.GetGenderAnswer(gender);
        }

        //// POST api/values
        //[HttpGet]
        //public string Post([FromBody]Message msg)
        //{
        //    //ChatAnswer answer = new ChatAnswer();
        //    //return answer.GetGenderAnswer(msg.message);
        //}
    }
}
