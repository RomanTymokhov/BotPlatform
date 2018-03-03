using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BotPlatform.ChatExtentions;
using BotPlatform.Cryptohacker;
using BotPlatform.ServerLogic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BotPlatform.Controllers
{
    [Route("api/Kunapublic")]
    public class KunapublicController : Controller
    {
         KunaHandler kunaHandler = new KunaHandler();

        // GET: api/Kunapublic/5
        [HttpGet]
        public string Get()
        {
            KunaAttributes attributes = new KunaAttributes(Request);

            return GetAnswer(attributes);
        }

        // POST: api/Kunapublic
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        private string GetAnswer(KunaAttributes attributes)
        {
            string answer = null;
            ChatAnswer chatAnswer = new ChatAnswer();

            if (attributes.Timestamp == "timestamp") answer = chatAnswer.GetTimestamp(kunaHandler.GetTimestamp());
            if (attributes.MarketPair != null) answer = chatAnswer.GetCurrensy(attributes.MarketPair, kunaHandler.GetCurrensyToBot(attributes.MarketPair));

            return answer;
        }
    }
}
