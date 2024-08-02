using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAppMVP.Models;

namespace WebAppMVP.Controllers
{
    public class HomeController : Controller
    {
        //field
        private readonly ILogger<HomeController> _logger;
        //Constructor
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        //Method
        public IActionResult Index()
        {
            return View();
        }
        //Method
        public IActionResult Privacy()
        {
            return View();
        }
        //??
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

        //Method
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
