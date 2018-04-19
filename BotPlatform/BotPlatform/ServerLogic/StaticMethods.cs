using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BotPlatform.ServerLogic
{
    public static class StaticMethods
    {
        public static int Rnd(List<string> answList)
        {
            Random rnd = new Random();
            return rnd.Next(answList.Count);
        }
    }
}
