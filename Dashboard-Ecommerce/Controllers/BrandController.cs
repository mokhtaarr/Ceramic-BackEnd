using DAL.Models;
using Dashboard_Ecommerce.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.EntityFrameworkCore;
using NToastNotify;

namespace Dashboard_Ecommerce.Controllers
{
    public class BrandController : Controller
    {
        private readonly MoDbContext _context;
        private readonly IToastNotification _toastNotification;
        public BrandController(MoDbContext context, IToastNotification toastNotification)
        {
            _context = context;
            _toastNotification = toastNotification;
        }
        public async Task<IActionResult> Index()
        {
            var Brands = await _context.SrBrands.ToListAsync();
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

            var brand = new SrBrand()
            {
                DescA = dto.DescA,
                DescE = dto.DescE
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
                DescE = brand.DescE
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

            brand.DescA = dto.DescA;
            brand.DescE = dto.DescE;

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
