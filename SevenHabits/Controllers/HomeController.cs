using Microsoft.AspNetCore.Mvc;
using SevenHabits.Models;
using System.Diagnostics;

namespace SevenHabits.Controllers
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

        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Quadrants()
        {
            return View();
        }
    }
}
