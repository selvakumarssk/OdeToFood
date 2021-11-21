using OdeToFood.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Web.Controllers
{
    public class GreetingController : Controller
    {
        // GET: Greeting
        public ActionResult Index(string name)
        {
            GreetingsModel greetingsModel = new GreetingsModel()
            {
                Message = "Hello!",
                Name=name ?? "No Name"
            };
            return View(greetingsModel);
        }
    }
}