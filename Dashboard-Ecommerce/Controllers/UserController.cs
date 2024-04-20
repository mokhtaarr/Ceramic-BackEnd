using DAL.Identity;
using Dashboard_Ecommerce.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NToastNotify;
using X.PagedList;

namespace Dashboard_Ecommerce.Controllers
{
    
    public class UserController : Controller
    {
        UserManager<DashBoardUser> _userManager;
        SignInManager<DashBoardUser> _signInManager;
        private readonly IToastNotification _toastNotification;
        private readonly UserManager<AppUser> _user;

        public UserController(UserManager<DashBoardUser> userManage, IToastNotification toastNotification, 
            SignInManager<DashBoardUser> signInManager, UserManager<AppUser> user)
        {
            _userManager = userManage;
            _toastNotification = toastNotification;
            _signInManager = signInManager;
            _user = user;
        }


        
       public async Task<IActionResult> GetAllAdmin(int pageIndex = 1, int pageSize = 50)
       {
           var users = await _userManager.Users.ToPagedListAsync(pageIndex, pageSize);

           return View(users);
       }

        public async Task<IActionResult> search(int pageIndex = 1, int pageSize = 50, string userName = "")
        {
            if(userName != string.Empty)
            {
                ViewBag.term = userName;
            }
            var users = await _userManager.Users.Where(s=>s.UserName == userName).ToPagedListAsync(pageIndex, pageSize);

            return View("GetAllAdmin", users);
        }



        [HttpGet]
        public IActionResult SignUp()
        {
            return View();  
        }


        [HttpPost]
        public async Task<IActionResult> SignUp(UserDto dto)
        {
            if(ModelState.IsValid == false)
                return View(dto);

            DashBoardUser user = new()
            {
                //FirstName = dto.FirstName,
                //LastName = dto.LastName,
                UserName = dto.UserName,
                Email = dto.Email,

            };

            IdentityResult Result = await  _userManager.CreateAsync(user,dto.Password);
            if (Result.Succeeded == false)
            {
                Result.Errors.ToList().ForEach(i =>
                {
                    ModelState.AddModelError("", i.Description);
                });
                return View();

            }
            else
            {
                _toastNotification.AddSuccessToastMessage("New registration added successfully");
                return RedirectToAction("SignIn", "User");
            }

            
        }

        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignIn(UserLoginDto dto)
        {
         
            if(ModelState.IsValid== false)
            {
                return View(dto);

            }
            else
            {
                var result = await _signInManager.PasswordSignInAsync(dto.UserName, dto.Password, dto.RememberMe, false);
                if (!result.Succeeded)
                {

                    ModelState.AddModelError("", "Invalid UserName or Password");
                    return View();
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
           
        }

        [HttpGet]
        public new async Task<IActionResult> SignOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("SignIn", "User");
        }

        [HttpGet]
        public IActionResult CreateUser()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateUserDto dto)
        {
            if (ModelState.IsValid == false)
                return View(dto);

            AppUser user = new AppUser
            {
                DisplayName = dto.userName,
                UserName = dto.userName,
                City = dto.City,
                Street = dto.Street,
                PhoneNumber = dto.PhoneNumber,
                Email = dto.Email,
                EmailConfirmed = true
               
            };

            var result = await _user.CreateAsync(user, dto.Password);

            if (!result.Succeeded)
            {
                 _toastNotification.AddErrorToastMessage("حدث خطا اثناء التسجيل");
            }

            _toastNotification.AddSuccessToastMessage("تم تسجيل مستخدم بنجاح");

            return RedirectToAction("Index", "Home");



        }

        public async Task<IActionResult> delete(string id)
        {
            if (id == null) return BadRequest("empty id");

            DashBoardUser user = await _userManager.Users.FirstOrDefaultAsync(s => s.Id == id);

            if (user == null) return NotFound("user not found");

             if(user.UserName == "softgo")
             {
                _toastNotification.AddErrorToastMessage("لا يمكن مسح الادمن الرئيسي");

                return BadRequest();

             }

            var result = await _userManager.DeleteAsync(user);

            if (result.Succeeded)
            {
                _toastNotification.AddSuccessToastMessage("تم مسح الإدمن بنجاح");
                return RedirectToAction("index", "home");
            }
            else
            {
                _toastNotification.AddErrorToastMessage("حدث خطا اثناء مسح الادمن ");

                return RedirectToAction("index", "home");
            }


        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> SignIn(UserLoginDto dto)
        //{
        //    if(ModelState.IsValid == false)
        //    return View();

        //    else
        //    {
        //        var reuslt = await _signInManager.PasswordSignInAsync(dto.Email, dto.Password,dto.RememberMe,false);
        //        if(reuslt.Succeeded == false)
        //        {
        //            ModelState.AddModelError("", "invalid Email or  Password ");
        //            return View();
        //        }
        //        else
        //        {
        //            return RedirectToAction("Index", "Home");
        //        }
        //    }

        //}
    }
}
