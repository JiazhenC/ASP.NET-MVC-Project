using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace Project.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View("LoginView");
        }

        [HttpPost]
        public IActionResult Index(String Id, String Password)
        {
            if(Id.Equals("P001") && Password.Equals("1234"))
            {
                HttpContext.Session.SetString("Id", "P001");
                return RedirectToAction("Index", "Main", new { area = "" });
            }
            else
            {
                ViewBag.Error = "Invalid Id or Password";
                return View("LoginView");
            }
        }
    }
}