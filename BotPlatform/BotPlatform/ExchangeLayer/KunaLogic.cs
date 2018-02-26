using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CunaWrapper;
using CunaWrapper.DataLevel.Enums;
using CunaWrapper.DataLevel.ServiceData;

namespace BotPlatform.ExchangeLayer
{
    public static class KunaLogic
    {
        public static Dictionary<string,string> GetCurrensysTosite()
        {
            Dictionary<string, string> curr = new Dictionary<string, string>();

            CunaClient cunaClient = new CunaClient();

            string btcuahCurrensy = cunaClient.GetTickerLine(MarketPair.btcuah).Result.ticker.buy.ToString();
            string ethuahCurrensy = cunaClient.GetTickerLine(MarketPair.ethuah).Result.ticker.buy.ToString();
            string bchuahCurrensy = cunaClient.GetTickerLine(MarketPair.bchuah).Result.ticker.buy.ToString();
            string wavesuahCurrensy = cunaClient.GetTickerLine(MarketPair.wavesuah).Result.ticker.buy.ToString();
            string xrpuahCurrensy = cunaClient.GetTickerLine(MarketPair.xrpuah).Result.ticker.buy.ToString();

            curr.Add("btc/uah", btcuahCurrensy);
            curr.Add("eth/uah", ethuahCurrensy);
            curr.Add("bch/uah", btcuahCurrensy);
            curr.Add("waves/uah", wavesuahCurrensy);
            curr.Add("xrp/uah", xrpuahCurrensy);

            return curr;
        }

        public static string GetCurrency(string pair)
        {
            CunaClient cunaClient = new CunaClient();

            return cunaClient.GetTickerLine(CunaLogic.EnumConvert(pair)).Result.ticker.buy.ToString();
        }
    }
}
