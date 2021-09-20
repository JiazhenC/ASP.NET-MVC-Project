using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project.Models;

namespace Project.Controllers
{
    public class CreateController : Controller
    {
        private readonly EventDataContext _db;
        public CreateController(EventDataContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Event e)
        {
            _db.Events.Add(e);
            _db.SaveChanges();
            return RedirectToAction("Index", "Main", new { area = "" });
        }
    }
}