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
            string gender = Request.Query.FirstOrDefault(p => p.Key == "gender").Value;
            string usrName = Request.Query.FirstOrDefault(p => p.Key == "first name").Value;

            return GetAnswer(gender, usrName);
        }

        private string GetAnswer(string gender, string usrName)
        {
            string answer = null;

            ChatAnswer chatAnswer = new ChatAnswer();

            if(gender != null && usrName == null) answer = chatAnswer.GetGenderAnswer(gender);

            if (gender != null && usrName != null) answer = chatAnswer.GetGenderNameAnswer(gender, usrName);

            return answer;
        }
    }
}
