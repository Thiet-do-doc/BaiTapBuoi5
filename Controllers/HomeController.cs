using BaiTapBuoi5.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using BaiTapBuoi5.Data;
using Microsoft.EntityFrameworkCore;

namespace BaiTapBuoi5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _db;

        public HomeController(ILogger<HomeController> logger, AppDbContext db)
        {
            _logger = logger;
            _db = db;
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

        public async Task<IActionResult> Products()
        {
            var products = await _db.Products
                .AsNoTracking()
                .ToListAsync();

            return View(products);
        }
        public async Task<IActionResult> TestSql()
        {
            bool connected = await _db.Database.CanConnectAsync();

            return Content(connected
                ? "Đã kết nối tới database!"
                : "Chưa kết nối được tới database.");
        }
    }
}
