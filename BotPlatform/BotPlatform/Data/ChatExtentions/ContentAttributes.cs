using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BotPlatform.Data.ChatExtentions
{
    public class ContentAttributes : ChatAttributes, IChatAttributes
    {
        private static ContentAttributes instance;
        private static object syncRoot = new Object();

        public string BotPic { get; private set; }

        private static bool nullFlag;

        public ContentAttributes(HttpRequest Request) : base(Request)
        {
            BotPic = Request.Query.FirstOrDefault(p => p.Key == "bot-pic").Value;

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
                        instance = new ContentAttributes(request);

                        if (nullFlag) chatAttributesList.Add(instance);
                    }

                }
            }
        }

        private void SetNullFlag()
        {
            if (BotPic == null) nullFlag = false;
            else nullFlag = true;
        }
    }
}
