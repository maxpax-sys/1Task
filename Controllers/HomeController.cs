using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Task1_1.Models;

namespace Task1_1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Welcomepage()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Доброе утро" : "Добрый день";
            return View("Welcomepage");
        }
        [HttpGet]
        public ActionResult Form()
        {
            return View("Form");
        }
        [HttpPost]
        public ActionResult Form(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                Repository.AddResponse(guestResponse);
                return View("Thanks", guestResponse);
            }
            else
            {

                return View();
            }
        }
        public ActionResult ListResponses()
        {
            return View(Repository.Responses);
        }



    }
}
