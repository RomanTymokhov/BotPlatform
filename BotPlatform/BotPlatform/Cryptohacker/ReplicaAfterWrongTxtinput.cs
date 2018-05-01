using BotPlatform.ServerLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BotPlatform.Cryptohacker
{
    public class ReplicaAfterWrongTxtinput : IBotReplicas
    {
        private List<string> maleReplicaUa;
        private List<string> maleReplicaRu;
        private List<string> femaleReplicaUa;
        private List<string> femaleReplicaRu;

        public ReplicaAfterWrongTxtinput()
        {
            maleReplicaUa = new List<string>();
            maleReplicaRu = new List<string>();
            femaleReplicaUa = new List<string>();
            femaleReplicaRu = new List<string>();

            FillReplicasRu();
            FillReplicasUa();
        }

        public string GetReplicaRu(string gender)
        {
            if (gender == "male") return maleReplicaRu.ElementAt(ComplementaryMethods.Rnd(maleReplicaRu));
            else return femaleReplicaRu.ElementAt(ComplementaryMethods.Rnd(femaleReplicaRu));
        }

        public string GetReplicaUa(string gender)
        {
            if (gender == "male") return maleReplicaUa.ElementAt(ComplementaryMethods.Rnd(maleReplicaUa));
            else return femaleReplicaUa.ElementAt(ComplementaryMethods.Rnd(femaleReplicaUa));
        }

        private void FillReplicasRu()
        {
            //Male
            maleReplicaRu.Add(" Эй, дружище, полегче...");
            maleReplicaRu.Add(" Парниша, не так быстро...");
            maleReplicaRu.Add(" И что это ты написал?");

            //Female
            femaleReplicaRu.Add(" Симпатюля, полегче...");
            femaleReplicaRu.Add(" Слишком много букв...");
            femaleReplicaRu.Add(" И что это ты написала?");
        }

        private void FillReplicasUa()
        {
            //Male
            maleReplicaUa.Add(" Гей, ковбоє, полегше...");
            maleReplicaUa.Add(" Воув, хлопче, не так швидко...");
            maleReplicaUa.Add(" І що це ти написав?");

            //Female
            femaleReplicaUa.Add(" Гей, кралечко, полегше...");
            femaleReplicaUa.Add(" Воув, дівонька, не так швидко...");
            femaleReplicaUa.Add(" І що це ти написала?");
        }
    }
}
