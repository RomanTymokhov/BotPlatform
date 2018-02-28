using System;
using KunaService;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BotPlatform.ServerLogic
{
    public class KunaHandler
    {
        private KunaServiseClient KunaServise { get; set; }

        public KunaHandler()
        {
            KunaServise = new KunaServiseClient(KunaServiseClient.EndpointConfiguration.BasicHttpBinding_IKunaServise, 
                                                "http://kunaservice.azurewebsites.net/KunaServise.svc");
        }

        public string GetTimestamp()
        {
            var timestamp = BotSerializer.Deserialize<string>(KunaServise.GetTimestampAsync().Result);            
            return BotSerializer.SendText(timestamp);
        }
    }
}
