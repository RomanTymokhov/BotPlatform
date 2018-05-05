using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BotPlatform.Data.ChatExtentions
{
    public class RoutAttributes : IChatAttributes
    {
        private static RoutAttributes instance;
        private static object syncRoot = new Object();

        public string LastVisitedBlockName { get; private set; }
        public string LastVisitedBlockId { get; private set; }
        public string LastBlockBeforeAi { get; private set; }
        public string CurrentBlockName { get; private set; }

        private static bool nullFlag;

        public RoutAttributes(HttpRequest Request)
        {
            LastVisitedBlockName = Request.Query.FirstOrDefault(p => p.Key == "last visited block name").Value;
            LastVisitedBlockId = Request.Query.FirstOrDefault(p => p.Key == "last visited block id").Value;
            LastBlockBeforeAi = Request.Query.FirstOrDefault(p => p.Key == "last-block-before-ai").Value;
            CurrentBlockName = Request.Query.FirstOrDefault(p => p.Key == "block-atr").Value;

            SetNullFlag();
        }

        public static void CreateInstance(HttpRequest request, List<IChatAttributes> ChatAttributesList)
        {
            if (instance == null)
            {
                lock (syncRoot)
                {
                    if (instance == null)
                    {
                        instance = new RoutAttributes(request);

                        if (nullFlag) ChatAttributesList.Add(instance);
                    }

                }
            }
        }

        private void SetNullFlag()
        {
            if (LastVisitedBlockName == null && LastVisitedBlockId == null &&
                LastBlockBeforeAi == null && CurrentBlockName == null) nullFlag = false;
            else nullFlag = true;
        }
    }
}
