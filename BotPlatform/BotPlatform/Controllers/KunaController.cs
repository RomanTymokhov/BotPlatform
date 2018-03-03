using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BotPlatform.Controllers
{
    public class KunaController : Controller
    {
        // GET: Kuna
        public ActionResult Index()
        {
            return View();
        }

        // GET: Kuna/Details/5
        [Route ("kuna/Course")]
        public ActionResult Course()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("BTCUAH", "10000");
            dictionary.Add("BCHUAH", "3000");
            dictionary.Add("XRPUAH", "30");

            return View(dictionary);
        }

        // GET: Kuna/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Kuna/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Kuna/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Kuna/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Kuna/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Kuna/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}