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

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(string firstName, string lastName)
        {
            ViewData["firstName"] = firstName;
            ViewData["lastName"] = lastName;

             return View();
        }

        [Route("Films")]
        [Route("About")]
       

        public IActionResult Films()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        [Route("Spiderman")]
        public IActionResult Spiderman()
        {
            return View();
        }

        [Route("Transformers")]
        public IActionResult Transformers()
        {
            return View();
        }

        [Route("Mario")]
        public IActionResult Mario()
        {
            return View();
        }

        [Route("Guardians")]
        public IActionResult Guardians()
        {
            return View();
        }

        [Route("FastX")]
        public IActionResult FastX()
        {
            return View();
        }

        [Route("Genres")]
        public IActionResult Genres()
        {
            return View();
        }

        [Route("Versions")]
        public IActionResult Versions()
        {
            return View();
        }

        [Route("Movies")]
        public IActionResult Movies()
        {
            return View();
        }

        [Route("TicketsSpiderman")]
        public IActionResult TicketsSpiderman()
        {
            return View();
        }
       
        [Route("TicketsGuardians")]
        public IActionResult TicketsGuardians()
        {
            return View();
        }

        [Route("TicketsFastX")]
        public IActionResult TicketsFastX()
        {
            return View();
        }

        [Route("TicketsMario")]
        public IActionResult TicketsMario()
        {
            return View();
        }

        [Route("TicketsTransformers")]
        public IActionResult TicketsTransformers()
        {
            return View();
        }

        [Route("Purchase")]
        public IActionResult Purchase()
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