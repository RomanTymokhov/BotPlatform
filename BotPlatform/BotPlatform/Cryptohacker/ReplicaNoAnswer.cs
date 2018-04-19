using BotPlatform.ServerLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BotPlatform.Cryptohacker
{
    public class ReplicaNoAnswer : IBotReplicas
    {
        private List<string> replicaUa;
        private List<string> replicaRu;

        public ReplicaNoAnswer()
        {
            replicaUa = new List<string>();
            replicaRu = new List<string>();

            FillReplicasRu();
            FillReplicasUa();
        }

        public string GetReplicaRu(string gender)
        {
            return replicaRu.ElementAt(StaticMethods.Rnd(replicaRu));
        }

        public string GetReplicaUa(string gender)
        {
            return replicaUa.ElementAt(StaticMethods.Rnd(replicaUa));
        }

        private void FillReplicasRu()
        {
            replicaRu.Add(" Как знаешь...");
            replicaRu.Add(" Тебе видней...");
            replicaRu.Add(" Ну ладно...");
        }

        private void FillReplicasUa()
        {
            replicaUa.Add(" Як знаеш...");
            replicaUa.Add(" Тобі видніше...");
            replicaUa.Add(" Ну добре...");
        }
    }
}
