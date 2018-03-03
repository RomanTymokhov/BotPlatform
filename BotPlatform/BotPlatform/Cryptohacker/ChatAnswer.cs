using System;
using System.Linq;
using System.Collections.Generic;
using BotPlatform.ServerLogic;
using System.Threading.Tasks;

namespace BotPlatform.Cryptohacker
{
    public class ChatAnswer
    {
        private List<string> maleAnswersToMax;
        private List<string> femaleAnswersToMax;

        public ChatAnswer()
        {
            maleAnswersToMax = new List<string>();
            femaleAnswersToMax = new List<string>();
            FillAnswers();
        }

        #region Max --> Gender
        //Логика ответа на имя бота с учетом гендерной принадлежности юзера
        public string GetGenderAnswer(string gender)
        {
            if (gender == "male")
                 return BotSerializer.SendText(maleAnswersToMax.ElementAt(Rnd(maleAnswersToMax)));
            else return BotSerializer.SendText(femaleAnswersToMax.ElementAt(Rnd(femaleAnswersToMax)));
        }

        private void FillAnswers()
        {
            FillMailAnswers();
            FillFemailAnswers();
        }

        private void FillMailAnswers()
        {
            maleAnswersToMax.Add("🤖 Гей, ковбоє, полегше...");
            maleAnswersToMax.Add("🤖 Воув, хлопче, не так швидко...");
            maleAnswersToMax.Add("🤖 І що це ти написав?");
        }

        private void FillFemailAnswers()
        {
            femaleAnswersToMax.Add("🤖 Гей, кралечко, полегше...");
            femaleAnswersToMax.Add("🤖 Воув, дівонька, не так швидко...");
            femaleAnswersToMax.Add("🤖 І що це ти написала?");
        }

        private int Rnd(List<string> answList)
        {
            Random rnd = new Random();
            return rnd.Next(answList.Count);
        }
        #endregion

        #region Gender + Name
        //Логика ответа с учетом гендерной принадлежности и имени

        public string GetGenderNameAnswer(string gender, string usrName)
        {
            if (gender == "male")
                return BotSerializer.SendText("🤖 " + usrName + ", ти мене кликав?");
            else
                return BotSerializer.SendText("🤖 " + usrName + ", ти мене кликала?");
        }

        #endregion

        #region Timestamp

        public string GetTimestamp(string timestamp)
        {
            return BotSerializer.SendText("Час на сервері: " + timestamp);
        }

        #endregion

        #region Currensys
        public string GetCurrensy(string marketPair, string currValue)
        {
            return BotSerializer.SendText("📈 " + marketPair.ToUpper() + ": " + currValue + " UAH");
        }
        #endregion
    }
}
