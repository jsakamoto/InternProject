// use TinyGPIO.cs
// https://github.com/sample-by-jsakamoto/SignalR-on-RaspberryPi/blob/master/myapp/TinyGPIO.cs
using MvcApplication2;
using myapp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading;

namespace MvcApplication2.Controllers
{
    public enum GPIODirection
    {
        In,
        Out
    }

    public class HomeController : Controller
    {
        [HttpPut]
        public ActionResult TurnOnLED()
        {
            return null;
        }

        [HttpPut]
        public ActionResult TurnOffLED()
        {
            return null;
        }

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult HelloWorld(string parameterName)
        {
            Console.WriteLine("Turn On 25...");
            var gpio25 = TinyGPIO.Export(25);
            gpio25.Direction = (myapp.GPIODirection)GPIODirection.Out;
            gpio25.Value = 1;

            if (parameterName == "test")
            {
                return Json(new { success = true, show = "On" }, JsonRequestBehavior.AllowGet);
            }
            return null;
        }
        public ActionResult HelloWorld2(string parameterName)
        {
            Console.WriteLine("Turn Off 25...");

            var gpio25 = TinyGPIO.Export(25);
            gpio25.Direction = (myapp.GPIODirection)GPIODirection.Out;
            gpio25.Value = 0;

            if (parameterName == "test2")
            {
                return Json(new { success = true, show = "Off" }, JsonRequestBehavior.AllowGet);
            }
            return null;
        }
       

    }
}







