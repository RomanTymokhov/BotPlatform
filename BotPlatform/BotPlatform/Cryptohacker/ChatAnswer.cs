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
                case "chart": return "📈 ";
                default: return "";
            }
        }

        //Логика ответа ПиктоБотов на непонятный ввод
        public string GetAfterWrongTxtinputAnswer(string gender, string botPic)
        {
            IBotReplicas botReplicas = new ReplicaAfterWrongTxtinput();

            switch (botPic)
            {
                case "max":
                    {
                        List<string> messages = new List<string>();
                        messages.Add(GetBotPic(botPic) + botReplicas.GetReplicaUa(gender));
                        return BotManager.SendText(messages);
                    }
                case "mark":
                    {
                        List<string> messages = new List<string>();
                        messages.Add(GetBotPic(botPic) + botReplicas.GetReplicaRu(gender));
                        return BotManager.SendText(messages);
                    }
                default:
                    {
                        List<string> messages = new List<string>();
                        messages.Add(GetBotPic(botPic) + " ??? Default Txtinput Answer");
                        return BotManager.SendText(messages);
                    }
            }
        }

        //Логика ответа ПиктоБотов на обращение к ним
        public string GetAfterBotsAppealAnswer(string gender, string usrName, string botPic)
        {
            IBotReplicas botReplicas = new ReplicaAfterBotsAppeal();

            switch(botPic)
            {
                case "max":
                    {
                        List<string> messages = new List<string>();
                        messages.Add(GetBotPic(botPic) + usrName + botReplicas.GetReplicaUa(gender));
                        return BotManager.SendText(messages);
                    }
                case "mark":
                    {
                        List<string> messages = new List<string>();
                        messages.Add(GetBotPic(botPic) + usrName + botReplicas.GetReplicaRu(gender));
                        return BotManager.SendText(messages);
                    }
                default:
                    {
                        List<string> messages = new List<string>();
                        messages.Add(GetBotPic(botPic) + "??? Default BotsAppealAnswer Answer");
                        return BotManager.SendText(messages);
                    }
            }
        }

        //Логика отвеа на вопрос ДА или НЕТ
        public string GetYesNoAnswer(string botPic)
        {
            IBotReplicas botReplicasYesNo = new ReplicaYesNoAnswer();

            switch (botPic)
            {
                case "max":
                    {
                        List<string> messages = new List<string>();
                        messages.Add(GetBotPic(botPic) + botReplicasYesNo.GetReplicaUa(botPic));
                        return BotManager.SendText(messages);
                    }
                case "mark":
                    {
                        List<string> messages = new List<string>();
                        messages.Add(GetBotPic(botPic) + botReplicasYesNo.GetReplicaRu(botPic));
                        return BotManager.SendText(messages);
                    }
                default:
                    {
                        List<string> messages = new List<string>();
                        messages.Add(GetBotPic(botPic) + "!!! Default Yes/No Answer");
                        return BotManager.SendText(messages);
                    }
            }
        }

        //Логика ответа на блок "Main Yes"
        public string GetAfterYesAnswer()
        {
            return "to do";
        }

        //Логика ответа на блок "Main No"
        public string GetAfterNoAnswer(string botPic, string gender)
        {
            IBotReplicas botReplicas = new ReplicaNoAnswer();
            IBotReplicas botReplicasSec = new ReplicaAfterNoAnswer();

            switch (botPic)
            {
                case "max":
                    {
                        List<string> messages = new List<string>();
                        messages.Add(GetBotPic(botPic) + botReplicas.GetReplicaUa(gender));
                        messages.Add(GetBotPic(botPic) + botReplicasSec.GetReplicaUa(gender));
                        return BotManager.SendText(messages);
                    }
                case "mark":
                    {
                        List<string> messages = new List<string>();
                        messages.Add(GetBotPic(botPic) + botReplicas.GetReplicaRu(gender));
                        messages.Add(GetBotPic(botPic) + botReplicasSec.GetReplicaRu(gender));
                        return BotManager.SendText(messages);
                    }
                default:
                    {
                        List<string> messages = new List<string>();
                        messages.Add(GetBotPic(botPic) + "!!! Default Main-No Answer");
                        return BotManager.SendText(messages);
                    }
            }
        }

        //Логика ответа если на вопрос макса вбита какая-то лобуда...
        public string GetDefaultAnswer(string botPic)
        {
            IBotReplicas botReplicasDefault = new ReplicaDefaultAnswer();

            switch (botPic)
            {
                case "max":
                    {
                        List<string> messages = new List<string>();
                        messages.Add(GetBotPic(botPic) + botReplicasDefault.GetReplicaUa(botPic));
                        return BotManager.SendText(messages);
                    }
                case "mark":
                    {
                        List<string> messages = new List<string>();
                        messages.Add(GetBotPic(botPic) + botReplicasDefault.GetReplicaRu(botPic));
                        return BotManager.SendText(messages);
                    }
                default:
                    {
                        List<string> messages = new List<string>();
                        messages.Add(GetBotPic(botPic) + "!!! Default Block");
                        return BotManager.SendText(messages);
                    }
            }
        }

        #region Timestamp

        public string GetTimestamp(string timestamp)
        {
            //return BotSender.SendText("Час на сервері: " + timestamp);
            return "Timestamp";
        }

        #endregion

        #region Currensys
        public string GetCurrensy(string marketPair, string currValue)
        {
            //return BotSender.SendText("📈 " + marketPair.ToUpper() + ": " + currValue + " UAH");
            return "Currency";
        }
        #endregion
    }
}
