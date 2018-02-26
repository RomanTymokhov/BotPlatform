using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BotPlatform.ExchangeLayer;
using Microsoft.AspNetCore.Mvc;

namespace BotPlatform.Controllers
{
    public class CurrensysController : Controller
    {
        public IActionResult Index()
        {
            return View(KunaLogic.GetCurrensysTosite());
        }
    }
}