using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using BotPlatform.Data.ChatAttrData.Interfaces;
using System.Threading.Tasks;

namespace BotPlatform.Data.ChatAttrData
{
    public class AiRoutAttributes : IRoutAttributes, IChatAttributes
    {
        //private static AiRoutAttributes instance;
        //private static object syncRoot = new Object();
        
        public string LastBlockBeforeAi { get; private set; }

        public bool nullFlag;

        public AiRoutAttributes(HttpRequest Request)
        {
            LastBlockBeforeAi = Request.Query.FirstOrDefault(p => p.Key == "last-block-before-ai").Value;

            SetNullFlag();
        }

        //public static void CreateInstance(HttpRequest request, List<IChatAttributes> ChatAttributesList)
        //{
        //    if (instance == null)
        //    {
        //        lock (syncRoot)
        //        {
        //            if (instance == null)
        //            {
        //                instance = new AiRoutAttributes(request);

        //                if (nullFlag) ChatAttributesList.Add(instance);
        //            }

        //        }
        //    }
        //}

        private void SetNullFlag()
        {
            if (LastBlockBeforeAi == null ) nullFlag = false;
            else nullFlag = true;
        }
    }
}
