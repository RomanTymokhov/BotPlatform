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
        public List<IChatAttributes> ChatAttributesList { get; protected set; }

        public ChatAttributes(HttpRequest Request)
        {
            ChatAttributesList = new List<IChatAttributes>();

            AiRoutAttributes aa = new AiRoutAttributes(Request);
            BehavioralAttributes ba = new BehavioralAttributes(Request);
            ContentAttributes coa = new ContentAttributes(Request);
            CustomerAttributes ca = new CustomerAttributes(Request);
            MainRoutAttributes ma = new MainRoutAttributes(Request);
            UrlParamAttributes ua = new UrlParamAttributes(Request);

            if (aa.nullFlag) ChatAttributesList.Add(aa);
            if (ba.nullFlag) ChatAttributesList.Add(ba);
            if (coa.nullFlag) ChatAttributesList.Add(coa);
            if (ca.nullFlag) ChatAttributesList.Add(ca);
            if (ma.nullFlag) ChatAttributesList.Add(ma);
            if (ua.nullFlag) ChatAttributesList.Add(ua);
        }

        public  T  GetCurrentAttribute<T>()
        {
            return ChatAttributesList.OfType<T>().FirstOrDefault(); ;

                //T returnedObject = default(T);
                //foreach (var item in ChatAttributesList)
                //{
                //    if (item is T) returnedObject = (T)item;
                //}
                //return returnedObject;
        }

    }
}

