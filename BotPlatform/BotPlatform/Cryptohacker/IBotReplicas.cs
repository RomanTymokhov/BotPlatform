using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BotPlatform.Cryptohacker
{
    interface IBotReplicas
    {
        string GetReplicaUa(string gender);

        string GetReplicaRu(string gender);
    }
}
