using System;
using System.Linq;
using System.Collections.Generic;
using BotPlatform.ServerLogic;
using System.Threading.Tasks;

namespace BotPlatform.Cryptohacker
{
    public class ChatAnswer
    {
        private List<string> defaultAnswersUa;
        private List<string> defaultAnswersRu;

        public ChatAnswer()
        {
            defaultAnswersUa = new List<string>();
            defaultAnswersRu = new List<string>();

            FillAnswers();
        }

        #region Block Fill Answers
        //Варианты сценариев ответа
        private void FillAnswers()
        {
            FillDefaultAnswers();
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

        private int Rnd(List<string> answList)
        {
            Random rnd = new Random();
            return rnd.Next(answList.Count);
        }

        private string GetBotPic(string botPic)
        {
            switch (botPic)
            {
                case "max": return "🤖 ";
                case "mark": return "👨‍🎓 ";
                default: return "";
            }
        }
        #endregion

        //Логика ответа ПиктоБотов на непонятный ввод
        public string GetAfterWrongTxtinputAnswer(string gender, string botPic)
        {
            IBotReplicas botReplicas = new AfterWrongTxtinputReplica();

            switch (botPic)
            {
                case "max": return BotSerializer.SendText(GetBotPic(botPic) + botReplicas.GetReplicaUa(gender));
                case "mark": return BotSerializer.SendText(GetBotPic(botPic) + botReplicas.GetReplicaRu(gender));
                default: return BotSerializer.SendText(GetBotPic(botPic) + " ???");
            }
        }

        //Логика ответа ПиктоБотов на обращение к ним
        public string GetAfterBotsAppealAnswer(string gender, string usrName, string botPic)
        {
            IBotReplicas botReplicas = new AfterBotsAppealReplica();

            switch(botPic)
            {
                case "max": return BotSerializer.SendText(GetBotPic(botPic) + usrName + botReplicas.GetReplicaUa(gender));
                case "mark": return BotSerializer.SendText(GetBotPic(botPic) + usrName + botReplicas.GetReplicaRu(gender));
                default: return BotSerializer.SendText(GetBotPic(botPic) + "????");
            }
        }

        #region Default Answer
        //Логтка ответа если на вопрос макса вбита какая-то лобуда...
        public string GetDefaultAnswer(string blockId, string botPic)
        {
            switch (blockId)
            {
                case "main-menu-blck":
                    {
                        if (botPic == "mark") return BotSerializer.SendText(GetBotPic(botPic) + " Просто введи \"ДА\" или \"НЕТ\" ");
                        else return BotSerializer.SendText(GetBotPic(botPic) + " Просто введи \"ТАК\" або \"НІ\" ");
                    };
                case "max-yes-no": return BotSerializer.SendText(GetBotPic(botPic) + " Відповіси \"ТАК\" або \"НІ\" ");
                case "mark-yes-no": return BotSerializer.SendText(GetBotPic(botPic) + " Ответь \"ДА\" или \"НЕТ\" ");
                default:
                    {
                        if (botPic== "mark") return BotSerializer.SendText(GetBotPic(botPic) + defaultAnswersRu.ElementAt(Rnd(defaultAnswersUa)));
                        else return BotSerializer.SendText(GetBotPic(botPic) + defaultAnswersUa.ElementAt(Rnd(defaultAnswersUa)));
                    }
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
