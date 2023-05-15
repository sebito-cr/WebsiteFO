﻿using Microsoft.AspNetCore.Mvc;
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
      // alle producten ophalen
      var rows = DatabaseConnector.GetRows("select * from product");

      // lijst maken om alle namen in te stoppen
      List<string> names = new List<string>();

      foreach (var row in rows)
      {
        // elke naam toevoegen aan de lijst met namen
        names.Add(row["naam"].ToString());
      }

      // de lijst met namen in de html stoppen
      return View(names);
    }
        public IActionResult Index()
        {
            return View();
        }
        [Route("Contact")]
        [Route("Films")]
        [Route("Location")]
        public IActionResult Contact()
        {
            return View();
        }

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