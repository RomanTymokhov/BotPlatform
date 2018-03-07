using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BotPlatform.Responses
{
    //Use this response to send files, which are up to 25MB in size.

    public class MediaResponse
    {
        [JsonProperty(PropertyName = "messages")]
        public List<Attachment> messageList;

        public MediaResponse()
        {
            messageList = new List<Attachment>();
        }

        public void CreateResponse(Attachment attach)
        {
            messageList.Add(attach);
        }
    }

    public class Attachment
    {
        [JsonProperty(PropertyName = "type")]
        public string type;

        [JsonProperty(PropertyName = "payload")]
        public Payload payload;

        public Attachment(string mediaType, string url)
        {
            type = mediaType;
            payload = new Payload(url);
        }
    }

    public class Payload
    {
        [JsonProperty(PropertyName = "url")]
        public string url;

        public Payload(string url)
        {
            this.url = url;
        }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum MediaAttachType
    {
        image,
        video,
        audio,
        file
    }
}
