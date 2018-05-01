using BotPlatform.ServerLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BotPlatform.Cryptohacker
{
    public class ReplicaAfterBotsAppeal : IBotReplicas
    {
        private List<string> maleCalledAnswersUa;
        private List<string> maleCalledAnswersRu;
        private List<string> femaleCalledAnswersUa;
        private List<string> femaleCalledAnswersRu;

        public ReplicaAfterBotsAppeal()
        {
            maleCalledAnswersUa = new List<string>();
            maleCalledAnswersRu = new List<string>();
            femaleCalledAnswersUa = new List<string>();
            femaleCalledAnswersRu = new List<string>();

            FillReplicasRu();
            FillReplicasUa();
        }

        public string GetReplicaRu(string gender)
        {
            if (gender == "male") return maleCalledAnswersRu.ElementAt(ComplementaryMethods.Rnd(maleCalledAnswersRu));
            else return femaleCalledAnswersRu.ElementAt(ComplementaryMethods.Rnd(femaleCalledAnswersRu));
        }

        public string GetReplicaUa(string gender)
        {
            if (gender == "male") return maleCalledAnswersUa.ElementAt(ComplementaryMethods.Rnd(maleCalledAnswersUa));
            else return femaleCalledAnswersUa.ElementAt(ComplementaryMethods.Rnd(femaleCalledAnswersUa));
        }

        private void FillReplicasRu()
        {
            //Male
            maleCalledAnswersUa.Add(", ти мене кликав?");
            maleCalledAnswersUa.Add(", це ти до мене?");
            maleCalledAnswersUa.Add(", потрібна допомога?");

            //Female
            femaleCalledAnswersUa.Add(", ти мене кликала?");
            femaleCalledAnswersUa.Add(", це ти до мене?");
            femaleCalledAnswersUa.Add(", потрібна допомога?");
        }

        private void FillReplicasUa()
        {
            //Male
            maleCalledAnswersRu.Add(", ты меня звал?");
            maleCalledAnswersRu.Add(", ты ко мне?");
            maleCalledAnswersRu.Add(", нужна помощь?");

            //Female
            femaleCalledAnswersRu.Add(", ти меня звала?");
            femaleCalledAnswersRu.Add(", ты ко мне?");
            femaleCalledAnswersRu.Add(", нужна помощь?");
        }
    }
}
