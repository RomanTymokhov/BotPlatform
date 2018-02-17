using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BotPlatform.ChatExtentions;
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
            AcceptedAttributes attributes = new AcceptedAttributes();
            //string gender = Request.Query.FirstOrDefault(p => p.Key == "gender").Value;
            //string usrName = Request.Query.FirstOrDefault(p => p.Key == "first name").Value;
            //string blckAtr = Request.Query.FirstOrDefault(p => p.Key == "block-atr").Value;

            return GetAnswer(attributes);
        }

        private string GetAnswer(AcceptedAttributes attributes)
        {
            string answer = null;

            ChatAnswer chatAnswer = new ChatAnswer();

            if(attributes.BlockAttribute == "simple set") answer = chatAnswer.GetGenderAnswer(attributes.Gender);

            if (attributes.BlockAttribute == "yes no") answer = chatAnswer.GetGenderNameAnswer(attributes.Gender, attributes.FirstName);

            return answer;
        }
    }
}
