using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BotPlatform.Data.ChatExtentions
{
    public class ChatAttributes
    {
        public static List<IChatAttributes> chatAttributesList;

        public ChatAttributes(HttpRequest Request)
        {
            chatAttributesList = new List<IChatAttributes>();

            BehavioralAttributes.CreateInstance(Request);
            CustomerAttributes.CreateInstance(Request);
            ContentAttributes.CreateInstance(Request);
            RoutAttributes.CreateInstance(Request);
            UrlParamAttributes.CreateInstance(Request);
        }

    }
}

