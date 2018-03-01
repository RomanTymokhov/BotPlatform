using System;
using KunaService;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BotPlatform.Data.KunaData;

namespace BotPlatform.ServerLogic
{
    public class KunaHandler
    {
        private KunaServiseClient KunaServise { get; set; }

        public KunaHandler()
        {
            KunaServise = new KunaServiseClient(KunaServiseClient.EndpointConfiguration.BasicHttpBinding_IKunaServise, 
                                                "http://kunaservice.azurewebsites.net/KunaServise.svc");
        }

        public string GetTimestamp()
        {
            return KunaServise.GetTimestampAsync().Result;
        }

        public string GetCurrensy(string marketPair)
        {
            var tickerLine = KunaServise.GetTickerlineAsync(marketPair).Result;

            return tickerLine.ticker.buy.ToString();
        }
    }
}
