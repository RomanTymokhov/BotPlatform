using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BotPlatform.Data.ChatExtentions
{
    public class ChatAttributes
    {
        public List<IChatAttributes> ChatAttributesList { get; private set; }

        public ChatAttributes(HttpRequest Request)
        {
            ChatAttributesList = new List<IChatAttributes>();

            BehavioralAttributes.CreateInstance(Request, ChatAttributesList);
            CustomerAttributes.CreateInstance(Request, ChatAttributesList);
            ContentAttributes.CreateInstance(Request, ChatAttributesList);
            RoutAttributes.CreateInstance(Request, ChatAttributesList);
            UrlParamAttributes.CreateInstance(Request, ChatAttributesList);
        }

        public T GetCurrentAttribute<T>()
        {
            //foreach (var item in ChatAttributesList)
            //{
            //    if (item is T) 
            //}

            //return ChatAttributesList.
        }

    }
}

