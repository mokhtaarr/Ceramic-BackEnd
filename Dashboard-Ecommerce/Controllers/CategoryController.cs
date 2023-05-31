using DAL.Models;
using Dashboard_Ecommerce.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NToastNotify;
using System.Threading.Tasks;

namespace Dashboard_Ecommerce.Controllers
{
    public class CategoryController : Controller
    {
        private readonly MoDbContext _context;
        private readonly IToastNotification _toastNotification;

        public CategoryController(MoDbContext context,IToastNotification toastNotification)
        {
            _context = context;
            _toastNotification = toastNotification;
        }

        public async Task<IActionResult> Index()
        {
            var cat = await _context.MsItemCategories.ToListAsync();
            
            return View(cat);
        }

        public IActionResult Create()
        {
            var cat = new CategoryDto();
            return View("CategoryForm",cat);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CategoryDto dto)
        {
            if (!ModelState.IsValid)
                return View("CategoryForm",dto);

            var catTable = new MsItemCategory()
            {
                ItemCatDescA = dto.ItemCatDescA,
                ItemCatDescE = dto.ItemCatDescE
            };

            await _context.MsItemCategories.AddAsync(catTable);
            catTable.ItemCatCode = (catTable.ItemCategoryId).ToString();
            _context.SaveChanges();

            _toastNotification.AddSuccessToastMessage("Category Created Successfully");


            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int? ItemCategoryId)
        {
            if (ItemCategoryId == null)
                return BadRequest();

            var cat = await _context.MsItemCategories.FindAsync(ItemCategoryId);

            if (cat == null)
                return NotFound();

            var catDto = new CategoryDto()
            {
                ItemCategoryId = cat.ItemCategoryId,
                ItemCatDescA = cat.ItemCatDescA,
                ItemCatDescE = cat.ItemCatDescE
            };

            return View("CategoryForm", catDto);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(CategoryDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var catFromTable = await _context.MsItemCategories.FindAsync(dto.ItemCategoryId);

            if (catFromTable == null)
                return NotFound();

            catFromTable.ItemCatDescA = dto.ItemCatDescA;
            catFromTable.ItemCatDescE = dto.ItemCatDescE;

            _context.SaveChanges();

            _toastNotification.AddSuccessToastMessage("Category Updated Successfully");

            return RedirectToAction(nameof(Index));
            
                
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return BadRequest();
            var cat = await _context.MsItemCategories.FindAsync(id);
            if (cat == null)
                return NotFound();

            _context.MsItemCategories.Remove(cat);
            _context.SaveChanges();
            return Ok();
        }
    }
}
