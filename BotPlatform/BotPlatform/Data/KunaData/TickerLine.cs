using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BotPlatform.Data.KunaData
{
    public class TickerLine
    {
        public int at;        
        public Ticker ticker;
    }

    public class Ticker
    {
        public decimal buy;
        public decimal sell;
        public decimal low;
        public decimal high;
        public decimal last;
        public decimal vol;
        public decimal amount;
    }
}
