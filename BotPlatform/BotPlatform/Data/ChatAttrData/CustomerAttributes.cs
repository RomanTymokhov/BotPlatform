using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using BotPlatform.Data.ChatAttrData.Interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace BotPlatform.Data.ChatAttrData
{
    public class CustomerAttributes : IChatAttributes
    {
        public string MessengerUserId { get; private set; }
        public string ChatfuelUserId { get; private set; }
        public string ProfilePicUrl { get; private set; }
        public string FirstName { get; private set; }
        public string UserEmail { get; private set; }
        public string UserPhone { get; private set; }
        public string Timezone { get; private set; }
        public string LastName { get; private set; }
        public string Gender { get; private set; }
        public string Locale { get; private set; }

        public bool nullFlag;

        public CustomerAttributes(HttpRequest Request)
        {
            MessengerUserId = Request.Query.FirstOrDefault(p => p.Key == "messenger user id").Value;
            ChatfuelUserId = Request.Query.FirstOrDefault(p => p.Key == "chatfuel user id").Value;
            ProfilePicUrl = Request.Query.FirstOrDefault(p => p.Key == "profile pic url").Value;
            FirstName = Request.Query.FirstOrDefault(p => p.Key == "first name").Value;
            UserEmail = Request.Query.FirstOrDefault(p => p.Key == "usr-email").Value;
            UserPhone = Request.Query.FirstOrDefault(p => p.Key == "usr-phone").Value;
            Timezone = Request.Query.FirstOrDefault(p => p.Key == "timezone").Value;
            LastName = Request.Query.FirstOrDefault(p => p.Key == "lastname").Value;
            Gender = Request.Query.FirstOrDefault(p => p.Key == "gender").Value;
            Locale = Request.Query.FirstOrDefault(p => p.Key == "locale").Value;

            SetNullFlag();
        }

        private void SetNullFlag()
        {
            if (MessengerUserId == null && ChatfuelUserId == null && ProfilePicUrl == null &&
                FirstName == null && UserEmail == null && UserPhone == null &&
                Timezone == null && LastName == null && Gender == null && Locale == null) nullFlag = false;
            else nullFlag = true;
        }
    }
}
