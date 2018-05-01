using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BotPlatform.Data.ChatExtentions
{
    public class UrlParamAttributes : ChatAttributes, IChatAttributes
    {
        private static UrlParamAttributes instance;
        private static object syncRoot = new Object();

        public string Source { get; private set; }
        public string Ref { get; private set; }

        private static bool nullFlag;

        public UrlParamAttributes(HttpRequest Request) : base(Request)
        {
            Source = Request.Query.FirstOrDefault(p => p.Key == "source").Value;
            Ref = Request.Query.FirstOrDefault(p => p.Key == "ref").Value;

            SetNullFlag();
        }

        public static void CreateInstance(HttpRequest request)
        {
            if (instance == null)
            {
                lock (syncRoot)
                {
                    if (instance == null)
                    {
                        instance = new UrlParamAttributes(request);

                        if (nullFlag) chatAttributesList.Add(instance);
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
