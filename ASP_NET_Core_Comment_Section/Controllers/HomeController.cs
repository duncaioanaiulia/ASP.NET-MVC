using ASP_NET_Core_Comment_Section.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASP_NET_Core_Comment_Section.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        //ControllerBase : A base class for an MVC controller without view support.
        //Controller : A base class for an MVC controller with view support.

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}