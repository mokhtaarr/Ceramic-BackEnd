using DAL.Identity;
using Dashboard_Ecommerce.Dtos;
using Dashboard_Ecommerce.services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NToastNotify;

namespace Dashboard_Ecommerce.Controllers
{
    public class SendOffersController : Controller
    {
        private readonly IMailingService _mailingService;
        private readonly IToastNotification _toastNotification;
        private readonly UserManager<AppUser> _userManager;

        public SendOffersController(IMailingService mailingService, IToastNotification toastNotification, UserManager<AppUser> userManager)
        {
            _mailingService = mailingService;
            _toastNotification = toastNotification;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index(MailRequestDto dto)
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SendMail(MailRequestDto dto)
        {
            await _mailingService.SendEmailAsync(dto.ToEmail, dto.Subject, dto.Body, dto.Attachments);
            _toastNotification.AddSuccessToastMessage("تم ارسال العرض الي الاعضاء بنجاح");

            return RedirectToAction("Index", "Home");
        }


        [HttpPost]
        public async Task<IActionResult> SendOfferToAllMembers(MailRequestDto dto)
        {
            List<AppUser> AllMembers = await _userManager.Users.ToListAsync();

            foreach (var member in AllMembers)
            {
                await _mailingService.SendEmailAsync(member.Email, dto.Subject, dto.Body, dto.Attachments);
            }

            _toastNotification.AddSuccessToastMessage("تم ارسال العرض الي الاعضاء بنجاح");
            return RedirectToAction("Index", "Home");


        }

    }
}
