using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BotPlatform.Data.ChatAttrData.Interfaces;

namespace BotPlatform.Data.ChatAttrData
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
            MainRoutAttributes.CreateInstance(Request, ChatAttributesList);
            UrlParamAttributes.CreateInstance(Request, ChatAttributesList);
        }

        public T GetCurrentAttribute<T>()
        {
            T voidObject = default(T);

            foreach (var item in ChatAttributesList)
            {
                if (item is T) voidObject = (T)item;
                else voidObject = default(T);
            }

            return voidObject;
        }

    }
}

