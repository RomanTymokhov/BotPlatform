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
    [Route("api/CryptohackerAnswer")]
    public class CryptohackerAnswerController : Controller
    {
        [HttpGet]
        public string Get()
        {
            AcceptedAttributes attributes = new AcceptedAttributes(Request);

            return GetAnswer(attributes);
        }

        private string GetAnswer(AcceptedAttributes attributes)
        {
            string answer = null;

            ChatAnswer chatAnswer = new ChatAnswer();

            if (attributes.BlockAttribute == "default-answer") answer = chatAnswer.GetGenderAnswer(attributes.Gender, attributes.BotPic);

            if (attributes.BlockAttribute == "yes-no") answer = chatAnswer.GetGenderNameAnswer(attributes.Gender, attributes.FirstName, attributes.BotPic);

            if (attributes.LastBlockBeforeAi != null) answer = chatAnswer.GetDefaultAnswer(attributes.LastBlockBeforeAi, attributes.BotPic);

            return answer;
        }
    }
}
