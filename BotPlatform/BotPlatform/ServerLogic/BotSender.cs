using BotPlatform.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BotPlatform.ServerLogic
{
    public static class BotSender
    {
        public static string SendText(List<string> messages)
        {
            return JsonConvert.SerializeObject(CreateResponse(messages));
        }

        public static string SendMedia(string mediaType, string mediaUrl)
        {
            MediaResponse response = new MediaResponse();
            Attachment attachment = new Attachment(mediaType, mediaUrl);
            response.CreateResponse(attachment);

            return JsonConvert.SerializeObject(response);
        }

        public static T Deserialize<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);            
        }

        private static TextResponse CreateResponse(List<string> msgList)
        {
            TextResponse text = new TextResponse();

            foreach (var msg in msgList)
            {
                text.CreateResponse(new Text(msg));
            }

            return text;
        }
    }
}
