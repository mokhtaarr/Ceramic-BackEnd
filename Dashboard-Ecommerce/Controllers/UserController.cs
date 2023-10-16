using DAL.Identity;
using Dashboard_Ecommerce.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;

namespace Dashboard_Ecommerce.Controllers
{
    
    public class UserController : Controller
    {
        UserManager<DashBoardUser> _userManager;
        SignInManager<DashBoardUser> _signInManager;
        private readonly IToastNotification _toastNotification;

        public UserController(UserManager<DashBoardUser> userManage, IToastNotification toastNotification, SignInManager<DashBoardUser> signInManager)
        {
            _userManager = userManage;
            _toastNotification = toastNotification;
            _signInManager = signInManager;
        }
        [Authorize]
        [HttpGet]
        public IActionResult SignUp()
        {
            return View();  
        }


        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignUp(UserDto dto)
        {
            if(ModelState.IsValid == false)
                return View(dto);

            DashBoardUser user = new()
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
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
