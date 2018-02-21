using Microsoft.AspNetCore.Http;
using System.Linq;

namespace BotPlatform.ChatExtentions
{
    public class AcceptedAttributes
    {
        public string LastUserFreeFormInput { get; set; }
        public string LastClickedButtonName { get; set; }
        public string LastVisitedBlockName { get; set; }
        public string LastVisitedBlockId { get; set; }
        public string MessengerUserId { get; set; }
        public string ChatfuelUserId { get; set; }
        public string BlockAttribute { get; set; }
        public string ProfilePicUrl { get; set; }
        public string UserEmail { get; set; }
        public string UserPhone { get; set; }
        public string FirstName { get; set; }
        public string Timezone { get; set; }
        public string Lastame { get; set; }
        public string Gender { get; set; }
        public string Source { get; set; }
        public string Locale { get; set; }
        public string Ref { get; set; }

        public AcceptedAttributes(HttpRequest Request)
        {
            LastUserFreeFormInput = Request.Query.FirstOrDefault(p => p.Key == "last user freeform input").Value;
            LastClickedButtonName = Request.Query.FirstOrDefault(p => p.Key == "last clicked button name").Value;
            LastVisitedBlockName = Request.Query.FirstOrDefault(p => p.Key == "last visited block name").Value;
            LastVisitedBlockId = Request.Query.FirstOrDefault(p => p.Key == "last visited block id").Value;
            MessengerUserId = Request.Query.FirstOrDefault(p => p.Key == "messenger user id").Value;
            ChatfuelUserId = Request.Query.FirstOrDefault(p => p.Key == "chatfuel user id").Value;
            BlockAttribute = Request.Query.FirstOrDefault(p => p.Key == "block attribute").Value;
            ProfilePicUrl = Request.Query.FirstOrDefault(p => p.Key == "profile pic url").Value;
            UserEmail = Request.Query.FirstOrDefault(p => p.Key == "usr-email").Value;
            UserPhone = Request.Query.FirstOrDefault(p => p.Key == "usr-phone").Value;
            FirstName = Request.Query.FirstOrDefault(p => p.Key == "first name").Value;
            Timezone = Request.Query.FirstOrDefault(p => p.Key == "timezone").Value;
            Lastame = Request.Query.FirstOrDefault(p => p.Key == "lastname").Value;
            Gender = Request.Query.FirstOrDefault(p => p.Key == "gender").Value;
            Source = Request.Query.FirstOrDefault(p => p.Key == "source").Value;
            Locale = Request.Query.FirstOrDefault(p => p.Key == "locale").Value;
            Ref = Request.Query.FirstOrDefault(p => p.Key == "ref").Value;
        }
    }
}
