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
        public string Source { get; private set; }
        public string Ref { get; private set; }

        public bool nullFlag;

        public UrlParamAttributes(HttpRequest Request)
        {
            Source = Request.Query.FirstOrDefault(p => p.Key == "source").Value;
            Ref = Request.Query.FirstOrDefault(p => p.Key == "ref").Value;

            SetNullFlag();
        }

        private void SetNullFlag()
        {
            if (Source == null && Ref == null) nullFlag = false;
            else nullFlag = true;
        }
    }
}
