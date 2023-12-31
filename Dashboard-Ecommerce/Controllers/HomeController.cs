using DAL.Models;
using Dashboard_Ecommerce.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Dashboard_Ecommerce.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MoDbContext _db;

        public HomeController(ILogger<HomeController> logger , MoDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            ViewData["CustomerOrders"] = _db.MsSalesOffers.Where(c => c.DeletedAt == null).Count();
            ViewData["CustomerCount"] = _db.MsCustomers.Where(c=>c.DeletedAt == null).Count();
            ViewData["Products"] = _db.MsItemCards.Where(c=>c.DeletedAt == null).Count();
            ViewData["Categories"] = _db.MsItemCategories.Where(c=>c.DeletedAt == null).Count();
            ViewData["Brands"] = _db.SrBrands.Where(c=>c.DeletedAt == null).Count();
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