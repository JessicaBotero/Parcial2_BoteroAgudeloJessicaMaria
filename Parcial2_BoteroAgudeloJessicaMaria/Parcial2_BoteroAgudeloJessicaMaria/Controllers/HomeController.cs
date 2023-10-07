using Microsoft.AspNetCore.Mvc;
using Parcial2_BoteroAgudeloJessicaMaria.DAL;
using Parcial2_BoteroAgudeloJessicaMaria.DAL.Entities;
using Parcial2_BoteroAgudeloJessicaMaria.Migrations;
using Parcial2_BoteroAgudeloJessicaMaria.Models;
using System.Diagnostics;

namespace Parcial2_BoteroAgudeloJessicaMaria.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IEnumerable<object> personas;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index => View();

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
        