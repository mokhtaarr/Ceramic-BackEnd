using DAL.Identity;
using infrastrucure.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using X.PagedList;

namespace Dashboard_Ecommerce.Controllers
{
    public class MembersController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public MembersController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<IActionResult> Index(int pageIndex = 1, int pageSize = 50)
        {
            var users = await _userManager.Users.ToPagedListAsync(pageIndex, pageSize);

            return View(users);
        }


    }
}
