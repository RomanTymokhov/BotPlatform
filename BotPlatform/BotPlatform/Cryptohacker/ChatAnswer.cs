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
        private List<string> mailAnswers;
        private List<string> femailAnswers;

        public ChatAnswer()
        {
            mailAnswers = new List<string>();
            femailAnswers = new List<string>();
            FillAnswers();
        }

        public string GetGenderAnswer(string gender)
        {
            if (gender == "m")
                 return JsonConvert.SerializeObject(PackageResponse(mailAnswers.ElementAt(Rnd(mailAnswers))));
            else return JsonConvert.SerializeObject(PackageResponse(femailAnswers.ElementAt(Rnd(femailAnswers))));
        }

        private TextResponse PackageResponse(string str)
        {
            TextResponse txtResp = new TextResponse();
            Message msg = new Message(str);
            txtResp.CreateResponse(msg);

            return txtResp;
        }

        private void FillAnswers()
        {
            FillMailAnswers();
            FillFemailAnswers();
        }

        private void FillMailAnswers()
        {
            mailAnswers.Add("Гей, ковбоє, полегше...");
            mailAnswers.Add("Воув, хлопче, не так швидко...");
            mailAnswers.Add("І що це ти написав?");
        }

        private void FillFemailAnswers()
        {
            femailAnswers.Add("Гей, кралечко, полегше...");
            femailAnswers.Add("Воув, дівонька, не так швидко...");
            femailAnswers.Add("І що це ти написала?");
        }

        private int Rnd(List<string> answList)
        {
            Random rnd = new Random();

            return rnd.Next(answList.Count);
        }
    }
}
