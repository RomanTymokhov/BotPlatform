using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BotPlatform.ChatExtentions;
using BotPlatform.Data.ChatAttrData;
using BotPlatform.Data.ChatAttrData.Interfaces;
using BotPlatform.Cryptohacker;
using Microsoft.AspNetCore.Mvc;

namespace BotPlatform.Controllers
{
    [Route("api/CryptohackerAnswer")]
    public class CryptohackerAnswerController : Controller
    {
        [HttpGet]
        public string Get()
        {
            ChatAttributes chatAttributes = new ChatAttributes(Request);
            ChatAnswer chatAnswer = new ChatAnswer();

            //Тут будет подключение к боту по ссылке
            //Бот должен принять аттрибуты и вернуть ответы

            if (chatAttributes.GetCurrentAttribute<AiRoutAttributes>() != null) return GetAiAnswer(chatAttributes, chatAnswer);
            else return GetNavAnswer(chatAttributes, chatAnswer);
        }

        private string GetNavAnswer(ChatAttributes attribute, ChatAnswer chatAnswer)
        {
            var block = attribute.GetCurrentAttribute<MainRoutAttributes>().CurrentBlockName;
            var name = attribute.GetCurrentAttribute<CustomerAttributes>().FirstName;
            var gender = attribute.GetCurrentAttribute<CustomerAttributes>().Gender;
            var botPic = attribute.GetCurrentAttribute<ContentAttributes>().BotPic;

            //дальнейшая оптимизация будет заключаться в обобщении данного метода
            //в ChatAnswr() методы необходимо передавать объекты IChatAttributes

            if (block == "default-answer") return chatAnswer.GetAfterWrongTxtinputAnswer(gender, botPic);
            else
                {
                    if (block == "yes-no") return chatAnswer.GetAfterBotsAppealAnswer(gender, name, botPic);
                    else return chatAnswer.GetErrorAnswer(block);
                }

            //if (attributes.BlockAttribute == "main-yes") answer = "//to do";

            //if (attributes.BlockAttribute == "main-no") answer = chatAnswer
        }

        private string GetAiAnswer(ChatAttributes attribute, ChatAnswer chatAnswer)
        {
            var block = attribute.GetCurrentAttribute<AiRoutAttributes>().LastBlockBeforeAi;
            var gender = attribute.GetCurrentAttribute<CustomerAttributes>().Gender;
            var botPic = attribute.GetCurrentAttribute<ContentAttributes>().BotPic;

            switch (block)
            {
                case "main-menu-blck": return chatAnswer.GetYesNoAnswer(botPic);
                case "main-no-blck": return chatAnswer.GetAfterNoAnswer(botPic, gender);
                case "max-yes-no": return chatAnswer.GetYesNoAnswer(botPic);
                case "mark-yes-no": return chatAnswer.GetYesNoAnswer(botPic);
                default: return chatAnswer.GetDefaultAnswer(botPic);
            }
        }
    }
}
