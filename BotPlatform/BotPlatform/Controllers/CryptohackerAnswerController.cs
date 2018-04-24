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

            if (attributes.LastBlockBeforeAi != null) answer = GetAnswerAfterAi(attributes, chatAnswer);

            if (attributes.BlockAttribute == "default-answer") answer = chatAnswer.GetAfterWrongTxtinputAnswer(attributes.Gender, attributes.BotPic);

            if (attributes.BlockAttribute == "yes-no") answer = chatAnswer.GetAfterBotsAppealAnswer(attributes.Gender, attributes.FirstName, attributes.BotPic);

            //if (attributes.BlockAttribute == "main-yes") answer = "//to do";

            //if (attributes.BlockAttribute == "main-no") answer = chatAnswer

            return answer;
        }

        private string GetAnswerAfterAi(AcceptedAttributes attributes, ChatAnswer chatAnswer)
        {
            switch(attributes.LastBlockBeforeAi)
            {
                case "main-menu-blck": return chatAnswer.GetYesNoAnswer(attributes.BotPic);
                case "main-no-blck": return chatAnswer.GetAfterNoAnswer(attributes.BotPic, attributes.Gender);
                case "max-yes-no": return chatAnswer.GetYesNoAnswer(attributes.BotPic);
                case "mark-yes-no": return chatAnswer.GetYesNoAnswer(attributes.BotPic);
                default: return chatAnswer.GetDefaultAnswer(attributes.BotPic);
            }
        }
    }
}
