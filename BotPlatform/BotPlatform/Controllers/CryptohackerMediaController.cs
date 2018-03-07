using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BotPlatform.Responses;
using BotPlatform.ServerLogic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BotPlatform.Controllers
{
    [Route("api/CryptohackerMedia")]
    public class CryptohackerMediaController : Controller
    {
        [HttpGet]
        public string Get()
        {
            return BotSerializer.SendMedia(MediaAttachType.image.ToString(), "https://static.intercomassets.com/avatars/482552/square_128/DSCF1621LS-1463954543.png?1463954543");
        }
    }
}
