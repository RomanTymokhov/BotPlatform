using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using BotPlatform.Data.ChatAttrData.Interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace BotPlatform.Data.ChatAttrData
{
    public class UrlParamAttributes : IChatAttributes
    {
        private static UrlParamAttributes instance;
        private static object syncRoot = new Object();

        public string Source { get; private set; }
        public string Ref { get; private set; }

        private static bool nullFlag;

        public UrlParamAttributes(HttpRequest Request)
        {
            Source = Request.Query.FirstOrDefault(p => p.Key == "source").Value;
            Ref = Request.Query.FirstOrDefault(p => p.Key == "ref").Value;

            SetNullFlag();
        }

        public static void CreateInstance(HttpRequest request, List<IChatAttributes> ChatAttributesList)
        {
            if (instance == null)
            {
                lock (syncRoot)
                {
                    if (instance == null)
                    {
                        instance = new UrlParamAttributes(request);

                        if (nullFlag) ChatAttributesList.Add(instance);
                    }

                }
            }
        }

        private void SetNullFlag()
        {
            if (Source == null && Ref == null) nullFlag = false;
            else nullFlag = true;
        }
    }
}
