using BotPlatform.ServerLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BotPlatform.Cryptohacker
{
    public class ReplicaYesNoAnswer : IBotReplicas
    {
        private List<string> answerYesNoUa;
        private List<string> answerYesNoRu;

        public ReplicaYesNoAnswer()
        {
            answerYesNoUa = new List<string>();
            answerYesNoRu = new List<string>();

            FillReplicasUa();
            FillReplicasRu();
        }

        public string GetReplicaRu(string gender)
        {
            return answerYesNoRu.ElementAt(StaticMethods.Rnd(answerYesNoRu));
        }

        public string GetReplicaUa(string gender)
        {
            return answerYesNoUa.ElementAt(StaticMethods.Rnd(answerYesNoUa));
        }

        private void FillReplicasUa()
        {
            answerYesNoUa.Add(" Набери \"ДА\" чи \"НІ\" ");
            answerYesNoUa.Add(" Посто набери \"ДА\" чи \"НІ\" ");
            answerYesNoUa.Add(" Введи \"ДА\" чи \"НІ\" ");
        }

        private void FillReplicasRu()
        {
            answerYesNoRu.Add(" Набери \"ДА\" или \"НЕТ\" ");
            answerYesNoRu.Add(" Просто набери \"ДА\" или \"НЕТ\" ");
            answerYesNoRu.Add(" Введи \"ДА\" или \"НЕТ\" ");
        }
    }
}
