using Microsoft.AspNetCore.Mvc;

namespace Dashboard_Ecommerce.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
