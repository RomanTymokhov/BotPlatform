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

        public string GetCurrensyToBot(string marketPair)
        {
            var tickerLine = KunaServise.GetTickerlineAsync(marketPair).Result;

            return tickerLine.ticker.buy.ToString();
        }

        public Dictionary<string, string> GetCurrencyToSite()
        {
            Dictionary<string, string> currency = new Dictionary<string, string>();

            currency.Add("btc/uah", KunaServise.GetTickerlineAsync("btcuah").Result.ticker.buy.ToString());
            currency.Add("eth/uah", KunaServise.GetTickerlineAsync("ethuah").Result.ticker.buy.ToString());
            currency.Add("bch/uah", KunaServise.GetTickerlineAsync("bchuah").Result.ticker.buy.ToString());
            currency.Add("xrp/uah", KunaServise.GetTickerlineAsync("xrpuah").Result.ticker.buy.ToString());
            currency.Add("waves/uah", KunaServise.GetTickerlineAsync("wavesuah").Result.ticker.buy.ToString());

            return currency;
        }
    }
}
