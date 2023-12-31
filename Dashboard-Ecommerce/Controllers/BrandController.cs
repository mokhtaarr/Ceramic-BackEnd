using DAL.Models;
using Dashboard_Ecommerce.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.SignalR.Protocol;
using Microsoft.EntityFrameworkCore;
using NToastNotify;
using X.PagedList;

namespace Dashboard_Ecommerce.Controllers
{
    [Authorize]
    public class BrandController : Controller
    {
        private readonly MoDbContext _context;
        private readonly IToastNotification _toastNotification;
        private readonly IWebHostEnvironment _hosting;


        public BrandController(MoDbContext context, IToastNotification toastNotification, IWebHostEnvironment hosting)
        {
            _context = context;
            _toastNotification = toastNotification;
            _hosting = hosting;
        }
        public async Task<IActionResult> Index(int pageIndex = 1, int pageSize = 50)
        {
            var Brands = await _context.SrBrands.ToPagedListAsync(pageIndex,pageSize);
            return View(Brands);
        }

        public IActionResult Create()
        {
            var AddBrand = new BrandDto();
            return View("BrandForm", AddBrand);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(BrandDto dto)
        {
            if (!ModelState.IsValid)
            {
                return View("BrandForm", dto);
            }

            string FileName = string.Empty;
            bool BrandHaveImage = false;

            if(dto.ImageFile != null)
            {
                string uploads = Path.Combine(_hosting.WebRootPath, "uploads");
                FileName = dto.ImageFile.FileName;
                string FullPath = Path.Combine(uploads, FileName);
                dto.ImageFile.CopyTo(new FileStream(FullPath, FileMode.Create));
                BrandHaveImage = true;
            }


            var brand = new SrBrand()
            {
                DescA = dto.DescA,
                DescE = dto.DescE,
                ImagePath = FileName,
                WithImage = BrandHaveImage
            };

            _context.SrBrands.Add(brand);
            _context.SaveChanges();

            _toastNotification.AddSuccessToastMessage("Brand Created Successfully");
             
            return RedirectToAction("Index");

        }

        public async Task<IActionResult> Edit(int? BrandId)
        {
            if(BrandId == null) 
                return BadRequest();

            var brand = await _context.SrBrands.FindAsync(BrandId);

            if (brand == null)
                return NotFound();

            var BrandEdit = new BrandDto()
            {
                BrandId = brand.BrandId,
                DescA = brand.DescA,
                DescE = brand.DescE,
                ImagePath = brand.ImagePath
            };


            return View("BrandForm", BrandEdit);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(BrandDto dto)
        {
            if (!ModelState.IsValid)
                return View("BrandForm", dto);

            var brand = await _context.SrBrands.FindAsync(dto.BrandId);

            if (brand == null)
                return NotFound();

            string FileName = string.Empty;
            bool BrandHaveImage = false;



            if (dto.ImageFile != null)
            {
                string uploads = Path.Combine(_hosting.WebRootPath, "uploads");
                FileName = dto.ImageFile.FileName;
                string FullPath = Path.Combine(uploads, FileName);

                // حذف الملف القديم إذا كان موجودًا
                if (!string.IsNullOrEmpty(brand.ImagePath))
                {
                    string FullOldPath = Path.Combine(uploads, brand.ImagePath);
                    System.IO.File.Delete(FullOldPath);
                }

                dto.ImageFile.CopyTo(new FileStream(FullPath, FileMode.Create));
                BrandHaveImage = true;
            }


            brand.DescA = dto.DescA;
            brand.DescE = dto.DescE;
            if (!string.IsNullOrEmpty(FileName))
            {
                brand.ImagePath = FileName;
                brand.WithImage = BrandHaveImage;

            }


            _context.SaveChanges();

            _toastNotification.AddSuccessToastMessage("Brand Updated Successfully");

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return BadRequest();
            var brand = await _context.SrBrands.FindAsync(id);
            if (brand == null)
                return NotFound();

            _context.SrBrands.Remove(brand);
            _context.SaveChanges();
            return Ok();
        }
    }
}
