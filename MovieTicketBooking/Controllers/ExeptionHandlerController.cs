using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MovieTicketBooking.Controllers
{
    public class ExeptionHandlerController : Controller
    {
        public IActionResult Index(string exeption)
        {
            ViewBag.message = exeption;
            return View();
        }
    }
}