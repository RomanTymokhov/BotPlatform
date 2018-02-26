using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BotPlatform.Responses;
using Newtonsoft.Json;

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

        private TextResponse PackageResponse(string str)
        {
            TextResponse txtResp = new TextResponse();
            Message msg = new Message(str);
            txtResp.CreateResponse(msg);

            return txtResp;
        }

        #region Max --> Gender
        //Логика ответа на имя бота с учетом гендерной принадлежности юзера
        public string GetGenderAnswer(string gender)
        {
            if (gender == "male")
                 return JsonConvert.SerializeObject(PackageResponse(maleAnswersToMax.ElementAt(Rnd(maleAnswersToMax))));
            else return JsonConvert.SerializeObject(PackageResponse(femaleAnswersToMax.ElementAt(Rnd(femaleAnswersToMax))));
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
                return JsonConvert.SerializeObject(PackageResponse("🤖 " + usrName + ", ти мене кликав?"));
            else
                return JsonConvert.SerializeObject(PackageResponse("🤖 " + usrName + ", ти мене кликала?"));
        }

        #endregion
    }
}
