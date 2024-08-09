using CPW219_PriceQuotationApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CPW219_PriceQuotationApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        Price defaultPrice = new();
        public IActionResult Index()
        {
            
            return View(defaultPrice);

        }

        [HttpPost]
        public IActionResult Index(Price p)
        {
            if (ModelState.IsValid)
            {
                return View(p);
            }
            return View(defaultPrice);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
