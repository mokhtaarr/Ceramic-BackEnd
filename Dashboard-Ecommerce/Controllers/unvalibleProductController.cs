using DAL.Models;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using X.PagedList;

namespace Dashboard_Ecommerce.Controllers
{
    public class unvalibleProductController : Controller
    {
        private readonly MoDbContext _db;
        private readonly IConfiguration _configuration;
        private readonly IToastNotification _toastNotification;

        public unvalibleProductController(MoDbContext db, IConfiguration configuration, IToastNotification toastNotification)
        {
            _db = db;
            _configuration = configuration;
            _toastNotification = toastNotification;
        }
        public async Task<IActionResult> Index(int pageIndex = 1, int pageSize = 50)
        {
            IPagedList<UnavailableProduct> product = await _db.UnavailableProducts.Where(c => c.DeletedAt == null).ToPagedListAsync(pageIndex, pageSize);
            ViewBag.ImagePath = _configuration.GetValue<string>("ImageSettings:UploadsProductsImage");
          
            return View(product);
        }

        public async Task<IActionResult> search(int pageIndex = 1, int pageSize = 50,string phone = "")
        {
            if(phone != string.Empty)
            {
                ViewBag.term = phone;
            }

            IPagedList<UnavailableProduct> product = await _db.UnavailableProducts.Where(c => c.DeletedAt == null && c.Phone == phone).ToPagedListAsync(pageIndex, pageSize);
            ViewBag.ImagePath = _configuration.GetValue<string>("ImageSettings:UploadsProductsImage");

            return View("index",product);
        }

        public async Task<ActionResult> delete(int id)
        {
            UnavailableProduct prd = await _db.UnavailableProducts.FindAsync(id);
            prd.DeletedAt = DateTime.Now;

            await _db.SaveChangesAsync();

            return Ok();
        }
    }
}
