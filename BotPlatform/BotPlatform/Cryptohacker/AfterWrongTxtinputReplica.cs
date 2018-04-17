using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BotPlatform.Cryptohacker
{
    public class AfterWrongTxtinputReplica : IBotReplicas
    {
        private List<string> maleReplicaUa;
        private List<string> maleReplicaRu;
        private List<string> femaleReplicaUa;
        private List<string> femaleReplicaRu;

        public AfterWrongTxtinputReplica()
        {
            FillReplicasRu();
            FillReplicasUa();
        }

        public string GetReplicaRu(string gender)
        {
            if (gender == "male") return maleReplicaRu.ElementAt(Rnd(maleReplicaRu));
            else return femaleReplicaRu.ElementAt(Rnd(femaleReplicaRu));
        }

        public string GetReplicaUa(string gender)
        {
            if (gender == "male") return maleReplicaUa.ElementAt(Rnd(maleReplicaUa));
            else return femaleReplicaUa.ElementAt(Rnd(femaleReplicaUa));
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

        private int Rnd(List<string> answList)
        {
            Random rnd = new Random();
            return rnd.Next(answList.Count);
        }
    }
}
