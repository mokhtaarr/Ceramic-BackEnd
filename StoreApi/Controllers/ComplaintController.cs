using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StoreApi.Dtos;

namespace StoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComplaintController : ControllerBase
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        private readonly MoDbContext _db;

        public ComplaintController(IWebHostEnvironment webHostEnvironment ,MoDbContext db)
        {
            _webHostEnvironment = webHostEnvironment;
            _db = db;
        }

        [HttpPost("AddingComplaint")]
        public async Task<IActionResult> AddingComplaint([FromForm] ComplaintDto dto)
        {

            var newComplain = new SrComplaint
            {
                ComDesc = dto.ComDesc,
                Phone = dto.Phone,
                Email = dto.Email,
                ComCode = dto.Phone
            };


            _db.SrComplaints.Add(newComplain);
            await _db.SaveChangesAsync();

            if (dto.Image != null && dto.Image.Length > 0)
            {
                var uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "uploads"); // اسم المجلد داخل wwwroot
                var cleanFileName = dto.Image.FileName.Replace("-", "");

                var uniqueFileName = Guid.NewGuid().ToString() + "_" + cleanFileName;
                var filePath = Path.Combine(uploadsFolder, uniqueFileName);

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await dto.Image.CopyToAsync(fileStream);
                }

                // قم بتحديث اسم الصورة في الحقل المضاف للـ SrComplaint
                newComplain.image = uniqueFileName;

                await _db.SaveChangesAsync(); // أعد حفظ التغييرات بما في ذلك اسم الصورة
            }


            return Ok(newComplain);

        }


    }
}
