using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebsiteFO.Models;
using MySql.Data;

namespace WebsiteFO.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
    
        public IActionResult Index()
        {
            return View();
        }
        [Route("Contact")]

        [HttpPost]
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Contact(string voornaam, string achternaam)
        {
            ViewData["voornaam"] = voornaam;
            ViewData["achternaam"] = achternaam;

             return View();
        }

        [Route("Films")]
        [Route("Location")]
      
        public IActionResult Films()
        {
            return View();
        }

        public IActionResult Location()
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