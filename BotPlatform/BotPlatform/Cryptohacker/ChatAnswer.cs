using System;
using System.Linq;
using System.Collections.Generic;
using BotPlatform.ServerLogic;
using System.Threading.Tasks;

namespace BotPlatform.Cryptohacker
{
    public class ChatAnswer
    {
        public ChatAnswer()
        {
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

        //Логика ответа ПиктоБотов на непонятный ввод
        public string GetAfterWrongTxtinputAnswer(string gender, string botPic)
        {
            IBotReplicas botReplicas = new ReplicaAfterWrongTxtinput();

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
            IBotReplicas botReplicas = new ReplicaAfterBotsAppeal();

            switch(botPic)
            {
                case "max": return BotSerializer.SendText(GetBotPic(botPic) + usrName + botReplicas.GetReplicaUa(gender));
                case "mark": return BotSerializer.SendText(GetBotPic(botPic) + usrName + botReplicas.GetReplicaRu(gender));
                default: return BotSerializer.SendText(GetBotPic(botPic) + "????");
            }
        }
        
        //Логика ответа если на вопрос макса вбита какая-то лобуда...
        public string GetDefaultAnswer(string botPic, bool defaultAnswer)
        {
            IBotReplicas botReplicasYesNo = new ReplicaYesNoAnswer();
            IBotReplicas botReplicasDefault = new ReplicaDefaultAnswer();

            var key = StaticMethods.Picconstruct(botPic, defaultAnswer);

            switch(key)
            {
                case "max-false": return BotSerializer.SendText(GetBotPic(botPic) + botReplicasYesNo.GetReplicaUa(botPic));
                case "mark-false": return BotSerializer.SendText(GetBotPic(botPic) + botReplicasYesNo.GetReplicaRu(botPic));
                default: return BotSerializer.SendText(GetBotPic(botPic) + botReplicasDefault.GetReplicaRu(botPic));
            }
        }

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
