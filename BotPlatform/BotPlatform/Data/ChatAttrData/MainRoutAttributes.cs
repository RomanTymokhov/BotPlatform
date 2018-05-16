using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using BotPlatform.Data.ChatAttrData.Interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace BotPlatform.Data.ChatAttrData
{
    public class MainRoutAttributes : IRoutAttributes, IChatAttributes
    {
        public string LastVisitedBlockName { get; private set; }
        public string LastVisitedBlockId { get; private set; }
        public string CurrentBlockName { get; private set; }

        public bool nullFlag;

        public MainRoutAttributes(HttpRequest Request)
        {
            LastVisitedBlockName = Request.Query.FirstOrDefault(p => p.Key == "last visited block name").Value;
            LastVisitedBlockId = Request.Query.FirstOrDefault(p => p.Key == "last visited block id").Value;
            CurrentBlockName = Request.Query.FirstOrDefault(p => p.Key == "block-atr").Value;

            SetNullFlag();
        }

        private void SetNullFlag()
        {
            if (LastVisitedBlockName == null && LastVisitedBlockId == null && CurrentBlockName == null) nullFlag = false;
            else nullFlag = true;
        }
    }
}
