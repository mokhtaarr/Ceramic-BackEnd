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
            var users = await _userManager.Users.Where(s=>s.DeletedAt == null).ToPagedListAsync(pageIndex, pageSize);

            return View(users);
        }

        public async Task<IActionResult> search(int pageIndex = 1, int pageSize = 50,string phone = "")
        {
            if(phone != string.Empty)
            {
                ViewBag.term = phone;
            }
            var users = await _userManager.Users.Where(s => s.DeletedAt == null && s.PhoneNumber == phone).ToPagedListAsync(pageIndex, pageSize);

            return View("index", users);
        }

        public async Task<IActionResult> delete(string id)
        {
            if(id == null) return BadRequest("empty id");

            AppUser user = await _userManager.Users.FirstOrDefaultAsync(s=>s.Id == id);

            if (user == null) return NotFound("user not found");

            user.DeletedAt = DateTime.Now;

            var result = await _userManager.DeleteAsync(user);

            if (result.Succeeded)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                // يمكنك التعامل مع الأخطاء هنا إذا لزم الأمر
                return RedirectToAction(nameof(Index));
            }


        }


    }
}
