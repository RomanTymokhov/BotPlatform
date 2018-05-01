using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BotPlatform.Data.ChatExtentions
{
    public class BehavioralAttributes: ChatAttributes, IChatAttributes
    {
        private static BehavioralAttributes instance;
        private static object syncRoot = new Object();

        public string LastUserFreeFormInput { get; private set; }
        public string LastClickedButtonName { get; private set; }

        private static bool nullFlag;

        protected BehavioralAttributes(HttpRequest Request) : base(Request)
        {
            LastUserFreeFormInput = Request.Query.FirstOrDefault(p => p.Key == "last user freeform input").Value;
            LastClickedButtonName = Request.Query.FirstOrDefault(p => p.Key == "last clicked button name").Value;

            SetNullFlag();
        }

        public static void CreateInstance(HttpRequest request)
        {
            if (instance == null)
            {
                lock (syncRoot)
                {
                    if (instance == null)
                    {
                        instance = new BehavioralAttributes(request);

                        if (nullFlag) chatAttributesList.Add(instance);
                    }
                        
                }
            }
        }

        private void SetNullFlag()
        {
            if (LastUserFreeFormInput == null && LastClickedButtonName == null) nullFlag = false;
            else nullFlag = true;
        }
    }
}
