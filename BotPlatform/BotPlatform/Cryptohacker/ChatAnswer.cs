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
                default: return BotSerializer.SendText(GetBotPic(botPic) + " ??? Default Txtinput Block");
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
                default: return BotSerializer.SendText(GetBotPic(botPic) + "??? Default BotsAppealAnswer Block");
            }
        }

        //Логика отвеа на вопрос ДА или НЕТ
        public string GetYesNoAnswer(string botPic)
        {
            IBotReplicas botReplicasYesNo = new ReplicaYesNoAnswer();

            switch (botPic)
            {
                case "max": return BotSerializer.SendText(GetBotPic(botPic) + botReplicasYesNo.GetReplicaUa(botPic));
                case "mark": return BotSerializer.SendText(GetBotPic(botPic) + botReplicasYesNo.GetReplicaRu(botPic));
                default: return BotSerializer.SendText(GetBotPic(botPic) + "!!! Default Yes/No Block");
            }
        }

        //Логика ответа на блок "Main Yes"
        public string GetAfterYesAnswer()
        {
            return "to do";
        }

        //Логика ответа на блок "Main No"
        public string GetAfterNoAnswer(string botPic)
        {
            IBotReplicas botReplicas = new ReplicaNoAnswer();

            switch(botPic)
            {
                case "max": return BotSerializer.SendText(GetBotPic(botPic) + botReplicas.GetReplicaUa(botPic));
                case "mark": return BotSerializer.SendText(GetBotPic(botPic) + botReplicas.GetReplicaRu(botPic));
                default: return BotSerializer.SendText(GetBotPic(botPic) + "!!! Default Main-No Block");
            }
        }

        //Логика ответа если на вопрос макса вбита какая-то лобуда...
        public string GetDefaultAnswer(string botPic)
        {
            IBotReplicas botReplicasDefault = new ReplicaDefaultAnswer();

            switch (botPic)
            {
                case "max": return BotSerializer.SendText(GetBotPic(botPic) + botReplicasDefault.GetReplicaUa(botPic));
                case "mark": return BotSerializer.SendText(GetBotPic(botPic) + botReplicasDefault.GetReplicaRu(botPic));
                default: return BotSerializer.SendText(GetBotPic(botPic) + "!!! Default Block");
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
