using DAL.Models;
using Dashboard_Ecommerce.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NToastNotify;

namespace Dashboard_Ecommerce.Controllers
{
    public class CompanyController : Controller
    {
        private  MoDbContext _db ;
        private readonly IToastNotification _toastNotification;

        public CompanyController(MoDbContext db,IToastNotification toastNotification)
        {
            _db = db;
            _toastNotification = toastNotification;
        }


        public async Task<IActionResult> Index()
        {
            MsCompany CompanyWord = await _db.MsCompanies.FirstOrDefaultAsync();
            return View(CompanyWord);
        }

        public async Task<IActionResult> Edit (int CompanyId)
        {
            if(CompanyId == 0)  return BadRequest("there are no data with this id"); 

            MsCompany GetCompanyWordData = await _db.MsCompanies.FirstOrDefaultAsync(c=>c.CompanyId == CompanyId);

            if (GetCompanyWordData == null) return NotFound("i can not found the data");

            MsCompanyDto dto = new MsCompanyDto
            {
              CompanyId = GetCompanyWordData.CompanyId,
              RemarksA = GetCompanyWordData.RemarksA,
              RemarksE = GetCompanyWordData.RemarksE,
            };

            return View(dto);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(MsCompanyDto dto)
        {
            if(!ModelState.IsValid) return View(dto) ;

            if (dto.CompanyId == null) return BadRequest("there are no data with this id");

            MsCompany GetCompanyWordData = await _db.MsCompanies.FirstOrDefaultAsync(c => c.CompanyId == dto.CompanyId);

            if (GetCompanyWordData == null) return NotFound("i can not found the data");

            GetCompanyWordData.RemarksA = dto.RemarksA;
            GetCompanyWordData.RemarksE = dto.RemarksE;

             _db.SaveChanges();

            _toastNotification.AddSuccessToastMessage("data Updated Successfully");
            return RedirectToAction("index");
        }
    }
}
