using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Day2.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Welcome(string name, int numberTimes=1, string message = "2552")
        {
            ViewData["Name"] = name;
           ViewBag.NumberTimes = numberTimes;
            ViewData["Message"] = message;
            return View();
        }
    }
}
