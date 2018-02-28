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
            return BotSerializer.SendText(KunaServise.GetTimestampAsync().Result);
        }
    }
}
