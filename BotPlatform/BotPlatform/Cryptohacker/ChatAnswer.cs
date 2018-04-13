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
        private List<string> maleCalledAnswers;
        private List<string> femaleCalledAnswers;
        private List<string> defaultAnswers;

        public ChatAnswer()
        {
            maleAnswersToMax = new List<string>();
            femaleAnswersToMax = new List<string>();
            maleCalledAnswers = new List<string>();
            femaleCalledAnswers = new List<string>();
            defaultAnswers = new List<string>();
            FillAnswers();
        }

        private void FillAnswers()
        {
            FillMailAnswers();
            FillFemailAnswers();
            FillMaleCalledAnswers();
            FillFemaleCalledAnswers();
            FillDefaultAnswers();
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

        private void FillMaleCalledAnswers()
        {
            maleCalledAnswers.Add(", ти мене кликав?");
            maleCalledAnswers.Add(", це ти до мене?");
            maleCalledAnswers.Add(", потрібна допомога?");
        }

        private void FillFemaleCalledAnswers()
        {
            femaleCalledAnswers.Add(", ти мене кликала?");
            femaleCalledAnswers.Add(", це ти до мене?");
            femaleCalledAnswers.Add(", потрібна допомога?");
        }

        private void FillDefaultAnswers()
        {
            defaultAnswers.Add("🤖 Хочь я й бот, але мій штучний інтелект ще не на стільки розумний щоб тебе зрозуміти...");
            defaultAnswers.Add("🤖 Твоя писанина спалила мій процессор...");
            defaultAnswers.Add("🤖 Мій мозок закипів від твоєї писанини...");
        }

        private int Rnd(List<string> answList)
        {
            Random rnd = new Random();
            return rnd.Next(answList.Count);
        }

        #region Max --> Gender
        //Логика ответа Макса на имя бота с учетом гендерной принадлежности юзера
        public string GetGenderAnswer(string gender)
        {
            if (gender == "male")
                 return BotSerializer.SendText(maleAnswersToMax.ElementAt(Rnd(maleAnswersToMax)));
            else return BotSerializer.SendText(femaleAnswersToMax.ElementAt(Rnd(femaleAnswersToMax)));
        }
        #endregion

        #region Gender + Name
        //Логика ответа Макса с учетом гендерной принадлежности и имени
        public string GetGenderNameAnswer(string gender, string usrName, string botPic)
        {
            if (gender == "male")
                return BotSerializer.SendText(GetBotPic(botPic) + usrName + maleCalledAnswers.ElementAt(Rnd(maleCalledAnswers)));
            else
                return BotSerializer.SendText(GetBotPic(botPic) + usrName + femaleCalledAnswers.ElementAt(Rnd(femaleCalledAnswers)));
        }

        private string GetBotPic(string botPic)
        {
            switch(botPic)
            {
                case "max": return "🤖 ";
                case "mark": return "👨‍🎓 ";
                default: return "";
            }
        }

        #endregion

        #region Default Answer
        //Логтка ответа если на вопрос макса вбита какая-то лобуда...
        public string GetDefaultAnswer(string blockId)
        {
            switch (blockId)
            {
                case "main-menu-blck": return BotSerializer.SendText("🤖 Просто введи \"ТАК\" або \"НІ\" ");
                case "5a85c0a7e4b0caec2e03281f": return BotSerializer.SendText("🤖 test YES text ");
                case "5a85c161e4b0caec2e057085": return BotSerializer.SendText("🤖 test NO text ");
                default: return BotSerializer.SendText(defaultAnswers.ElementAt(Rnd(defaultAnswers)));
            }
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
