using DAL.interfaces;
using DAL.Models;
using Dashboard_Ecommerce.Dtos;
using Dashboard_Ecommerce.services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NToastNotify;
using System.Data.SqlTypes;
using X.PagedList;

namespace Dashboard_Ecommerce.Controllers
{
    public class ComplaintsController : Controller
    {
        private readonly MoDbContext _db;
        private readonly IConfiguration _configuration;
        private readonly IToastNotification _toastNotification;
        private readonly IEmailSender _emailSender;
        private readonly IMailingService _mailingService;

        public ComplaintsController(MoDbContext db, IConfiguration configuration, IToastNotification toastNotification, IEmailSender emailSender, IMailingService mailingService = null)
        {
            _db = db;
            _configuration = configuration;
            _toastNotification = toastNotification;
            _emailSender = emailSender;
            _mailingService = mailingService;
        }

        public async Task<IActionResult> Index(int pageIndex = 1, int pageSize = 50)
        {
           IPagedList<SrComplaint> userComplaints  = await _db.SrComplaints.Where(c=>c.DeletedAt == null).ToPagedListAsync(pageIndex, pageSize);
            ViewBag.ImagePath = _configuration.GetValue<string>("ImageSettings:UploadsPath");
            Console.WriteLine(ViewBag.ImagePath);
            return View(userComplaints);
        }

        public async Task<IActionResult> search(int pageIndex = 1, int pageSize = 50,string phone = "")
        {
            if(phone != string.Empty)
            {
                ViewBag.term = phone;
            }


            IPagedList<SrComplaint> userComplaints = await _db.SrComplaints.Where(c => c.DeletedAt == null && c.Phone == phone).ToPagedListAsync(pageIndex, pageSize);
            ViewBag.ImagePath = _configuration.GetValue<string>("ImageSettings:UploadsPath");
            Console.WriteLine(ViewBag.ImagePath);
            return View( "index",userComplaints);
        }

        public async Task<ActionResult> delete(int id)
        {
            SrComplaint getComplaintData = await _db.SrComplaints.FindAsync(id);
            getComplaintData.DeletedAt = DateTime.Now;

            await _db.SaveChangesAsync();

            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> EmailReplay(int id)
        {
            if (id == null)
                return BadRequest();

            SrComplaint getComplaintData = await _db.SrComplaints.FindAsync(id);

            if (getComplaintData == null)
            {
                _toastNotification.AddErrorToastMessage("حدث خطاء اثناء الرد علي الشكوى");
                return RedirectToAction("index");
            };


            var complaintDto = new complaintDto
            {
                ComId = getComplaintData.ComId,
                Remarks = getComplaintData.Remarks,

            };

            return View(complaintDto);

        }

        [HttpPost]
        public async Task<IActionResult> SendEmailReplay(complaintDto dto)
        {
            if (!ModelState.IsValid)
                return View("EmailReplay",dto);

            SrComplaint complaint = await _db.SrComplaints.FindAsync(dto.ComId);

            if (complaint == null)
                return NotFound();

            complaint.Remarks = dto.Remarks;
            await _db.SaveChangesAsync();

            //var senderEmail = _configuration["ReturnPaths:SenderEmail"];

            //await _emailSender.SendEmailAsync(senderEmail,complaint.Email,dto.Subject, dto.Remarks);

            //_toastNotification.AddSuccessToastMessage("تم ارسال البريد بنجاح");

            await _mailingService.SendEmailAsync(complaint.Email, dto.Subject, dto.Remarks, dto.Image);

            return RedirectToAction(nameof(Index));



        }

    }
}
