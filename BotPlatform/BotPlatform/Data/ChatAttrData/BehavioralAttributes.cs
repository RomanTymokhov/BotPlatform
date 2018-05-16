using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using BotPlatform.Data.ChatAttrData.Interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace BotPlatform.Data.ChatAttrData
{
    public class BehavioralAttributes: IChatAttributes
    {
        public string LastUserFreeFormInput { get; private set; }
        public string LastClickedButtonName { get; private set; }

        public bool nullFlag;

        public BehavioralAttributes(HttpRequest Request) 
        {
            LastUserFreeFormInput = Request.Query.FirstOrDefault(p => p.Key == "last user freeform input").Value;
            LastClickedButtonName = Request.Query.FirstOrDefault(p => p.Key == "last clicked button name").Value;

            SetNullFlag();
        }

        private void SetNullFlag()
        {
            if (LastUserFreeFormInput == null && LastClickedButtonName == null) nullFlag = false;
            else nullFlag = true;
        }
    }
}
