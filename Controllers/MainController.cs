using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Project.Models;

namespace Project.Controllers
{
    public class MainController : Controller
    {
        private readonly EventDataContext _db;
        public MainController(EventDataContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("Id") != null)
            {
                var events = _db.Events.OrderBy(x => x.Date).ToArray();
                ViewBag.Events = events;
                return View("Event");
            }
            else
            {
                ViewBag.Error = "Please Log In";
                return View("~/Views/Login/LoginView.cshtml");
            }
        }
    }
}