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

            if (attributes.LastBlockBeforeAi != null) answer = GetAnswerAfterAi(attributes.LastBlockBeforeAi, attributes.BotPic, chatAnswer);

            if (attributes.BlockAttribute == "default-answer") answer = chatAnswer.GetAfterWrongTxtinputAnswer(attributes.Gender, attributes.BotPic);

            if (attributes.BlockAttribute == "yes-no") answer = chatAnswer.GetAfterBotsAppealAnswer(attributes.Gender, attributes.FirstName, attributes.BotPic);

            return answer;
        }

        private string GetAnswerAfterAi(string lastBlockBeforeAi, string botPic, ChatAnswer chatAnswer)
        {
            switch(lastBlockBeforeAi)
            {
                case "main-menu-blck": return chatAnswer.GetYesNoAnswer(botPic);
                case "max-yes-no": return chatAnswer.GetYesNoAnswer(botPic);
                case "mark-yes-no": return chatAnswer.GetYesNoAnswer(botPic);
                default: return chatAnswer.GetDefaultAnswer(botPic);
            }
        }
    }
}
