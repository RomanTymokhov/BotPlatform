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

            if (chatAttributes.GetCurrentAttribute<AiRoutAttributes>() != null)
                 return GetAiAnswerAsync(chatAttributes, chatAnswer).GetAwaiter().GetResult();
            else return GetNavAnswer(chatAttributes, chatAnswer).GetAwaiter().GetResult();
        }

        private async Task<string> GetNavAnswer(ChatAttributes attribute, ChatAnswer chatAnswer)
        {
            //дальнейшая оптимизация будет заключаться в обобщении данного метода
            //в ChatAnswr() методы необходимо передавать объекты IChatAttributes

            if (await Task.Factory.StartNew(() => attribute.GetCurrentAttribute<MainRoutAttributes>().CurrentBlockName) == "default-answer")
                return chatAnswer.GetAfterWrongTxtinputAnswer(await Task.Factory.StartNew(() => attribute.GetCurrentAttribute<CustomerAttributes>().Gender), 
                                                              await Task.Factory.StartNew(() => attribute.GetCurrentAttribute<ContentAttributes>().BotPic));
            else
                {
                    if (await Task.Factory.StartNew(() => attribute.GetCurrentAttribute<MainRoutAttributes>().CurrentBlockName == "yes-no")) 
                         return chatAnswer.GetAfterBotsAppealAnswer(await Task.Factory.StartNew(() => attribute.GetCurrentAttribute<CustomerAttributes>().Gender),
                                                                    await Task.Factory.StartNew(() => attribute.GetCurrentAttribute<CustomerAttributes>().FirstName), 
                                                                    await Task.Factory.StartNew(() => attribute.GetCurrentAttribute<ContentAttributes>().BotPic));
                    else return chatAnswer.GetErrorAnswer(await Task.Factory.StartNew(() => attribute.GetCurrentAttribute<MainRoutAttributes>().CurrentBlockName));
                }

            //if (attributes.BlockAttribute == "main-yes") answer = "//to do";

            //if (attributes.BlockAttribute == "main-no") answer = chatAnswer
        }

        private async Task<string> GetAiAnswerAsync(ChatAttributes attribute, ChatAnswer chatAnswer)
        {
            switch (await Task.Factory.StartNew(() => attribute.GetCurrentAttribute<AiRoutAttributes>().LastBlockBeforeAi))
            {
                case "main-menu-blck": return chatAnswer.GetYesNoAnswer(await Task.Factory.StartNew(() => attribute.GetCurrentAttribute<ContentAttributes>().BotPic));
                case "main-no-blck": return chatAnswer.GetAfterNoAnswer(await Task.Factory.StartNew(() => attribute.GetCurrentAttribute<ContentAttributes>().BotPic), 
                                                                        await Task.Factory.StartNew(() => attribute.GetCurrentAttribute<CustomerAttributes>().Gender));
                case "max-yes-no": return chatAnswer.GetYesNoAnswer(await Task.Factory.StartNew(() => attribute.GetCurrentAttribute<ContentAttributes>().BotPic));
                case "mark-yes-no": return chatAnswer.GetYesNoAnswer(await Task.Factory.StartNew(() => attribute.GetCurrentAttribute<ContentAttributes>().BotPic));
                default: return chatAnswer.GetDefaultAnswer(await Task.Factory.StartNew(() => attribute.GetCurrentAttribute<ContentAttributes>().BotPic));
            }
        }
    }
}
