using BotPlatform.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BotPlatform.ServerLogic
{
    public static class BotSerializer
    {
        public static string SendText(string message)
        {
            TextResponse txtResp = new TextResponse();
            Message msg = new Message(message);
            txtResp.CreateResponse(msg);

            return JsonConvert.SerializeObject(txtResp);
        }

        public static T Deserialize<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);            
        }
    }
}
