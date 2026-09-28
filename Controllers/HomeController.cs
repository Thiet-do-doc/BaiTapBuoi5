using BaiTapBuoi5.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BaiTapBuoi5.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Weekend()
        {
            return View();
        }

        public IActionResult Products()
        {
            var products = new List<Product>
    {
        new Product { Id = 1, Name = "Bàn phím", Price = 350000 },
        new Product { Id = 2, Name = "Chuột", Price = 180000 },
        new Product { Id = 3, Name = "Màn hình", Price = 2500000 }
    };

            return View(products);
        }
    }
}
