using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BotPlatform.ChatExtentions
{
    public class KunaAttributes
    {
        public string Timestamp { get; set; }
        public string MarketPair { get; set; }

        public KunaAttributes (HttpRequest Request)
        {
            Timestamp = Request.Query.FirstOrDefault(p => p.Key == "timestamp").Value;
            MarketPair = Request.Query.FirstOrDefault(p => p.Key == "marketpair").Value;
        }
    }
}
