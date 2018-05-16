using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using BotPlatform.Data.ChatAttrData.Interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace BotPlatform.Data.ChatAttrData
{
    public class ContentAttributes : IChatAttributes
    {
        public string BotPic { get; private set; }

        public bool nullFlag;

        public ContentAttributes(HttpRequest Request)
        {
            BotPic = Request.Query.FirstOrDefault(p => p.Key == "bot-pic").Value;

            SetNullFlag();
        }

        private void SetNullFlag()
        {
            if (BotPic == null) nullFlag = false;
            else nullFlag = true;
        }
    }
}
