using BotPlatform.ServerLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BotPlatform.Cryptohacker
{
    public class ReplicaAfterNoAnswer : IBotReplicas
    {
        private List<string> maleReplicaUa;
        private List<string> maleReplicaRu;
        private List<string> femaleReplicaUa;
        private List<string> femaleReplicaRu;

        public ReplicaAfterNoAnswer()
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
            if (gender == "male") return maleReplicaRu.ElementAt(StaticMethods.Rnd(maleReplicaRu));
            else return femaleReplicaRu.ElementAt(StaticMethods.Rnd(femaleReplicaRu));
        }

        public string GetReplicaUa(string gender)
        {
            if (gender == "male") return maleReplicaUa.ElementAt(StaticMethods.Rnd(maleReplicaUa));
            else return femaleReplicaUa.ElementAt(StaticMethods.Rnd(femaleReplicaUa));
        }

        private void FillReplicasRu()
        {
            //Male
            maleReplicaRu.Add(" Но если передумал, то я здесь");
            maleReplicaRu.Add(" Но если передумал - я рядом");
            maleReplicaRu.Add(" Понадоблюсь - зови!");

            //Female
            femaleReplicaRu.Add(" Но если передумала, то я здесь");
            femaleReplicaRu.Add(" Но если передумала - я рядом");
            femaleReplicaRu.Add(" Понадоблюсь - зови!");
        }

        private void FillReplicasUa()
        {
            //Male
            maleReplicaUa.Add(" Та якщо передумав, то я тут");
            maleReplicaUa.Add(" Та якщо передумав - я поруч");
            maleReplicaUa.Add(" Буду потрібен - кликай!");

            //Female
            femaleReplicaUa.Add(" Та якщо передумала то я тут");
            femaleReplicaUa.Add(" Та якщо передумала - я поруч");
            femaleReplicaUa.Add(" Буду потрібен - кликай");
        }
    }
}
