using System.Collections.Generic;
using Newtonsoft.Json;

namespace BotPlatform.Responses
{
    public class TextResponse
    {
        [JsonProperty(PropertyName = "messages")]
        public List<Text> textResponse;

        public TextResponse()
        {
            textResponse = new List<Text>();
        }

        public void CreateMessage(Text msg)
        {
            textResponse.Add(msg);
        }
    }

    public class Text
    {
        [JsonProperty(PropertyName = "text")]
        public string message;

        public Text(string msg)
        {
            message = msg;
        }
    }
}
