using BotPlatform.ServerLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BotPlatform.Cryptohacker
{
    public class ReplicaDefaultAnswer : IBotReplicas
    {
        private List<string> defaultAnswersUa;
        private List<string> defaultAnswersRu;

        public ReplicaDefaultAnswer()
        {
            defaultAnswersUa = new List<string>();
            defaultAnswersRu = new List<string>();
        }

        public string GetReplicaRu(string gender)
        {
            return defaultAnswersRu.ElementAt(StaticMethods.Rnd(defaultAnswersRu));
        }

        public string GetReplicaUa(string gender)
        {
            return defaultAnswersUa.ElementAt(StaticMethods.Rnd(defaultAnswersUa));
        }

        private void FillDefaultAnswers()
        {
            defaultAnswersUa.Add(" Мій штучний інтелект ще не на стільки розумний щоб тебе зрозуміти...");
            defaultAnswersUa.Add(" Твоя писанина спалила мій процессор...");
            defaultAnswersUa.Add(" Мій мозок закипів від твоєї писанини...");

            defaultAnswersRu.Add(" Мой искуственный интеллект тебя не понял...");
            defaultAnswersRu.Add(" Не могу тебя понять...");
            defaultAnswersRu.Add(" Не могу понять, что это написано...");
        }
    }
}
