using DAL.Models;
using Dashboard_Ecommerce.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NToastNotify;
using System.Security.Cryptography;
using System.Threading.Tasks;
using X.PagedList;

namespace Dashboard_Ecommerce.Controllers
{
    [Authorize]
    public class CategoryController : Controller
    {
        private readonly MoDbContext _context;
        private readonly IToastNotification _toastNotification;
        private readonly IWebHostEnvironment _hosting;


        public CategoryController(MoDbContext context,IToastNotification toastNotification,IWebHostEnvironment hosting)
        {
            _context = context;
            _toastNotification = toastNotification;
            _hosting = hosting;
        }

        public async Task<IActionResult> Index(int pageIndex = 1, int pageSize = 50)
        {
            var cat = await _context.MsItemCategories.OrderByDescending(c=>c.ItemCategoryId).ToPagedListAsync(pageIndex, pageSize);
            
            return View(cat);
        }
        [HttpPost]
        public async Task<IActionResult> IndexFilter(int pageIndex = 1, int pageSize = 50,string ItemCatDescA = "")
        {
            var cat = await _context.MsItemCategories.OrderByDescending(c => c.ItemCategoryId).ToPagedListAsync(pageIndex, pageSize);

            if(ItemCatDescA != string.Empty)
            {
                cat = await _context.MsItemCategories.OrderByDescending(c => c.ItemCategoryId).Where(c=>c.ItemCatDescA == ItemCatDescA).ToPagedListAsync(pageIndex, pageSize);
                ViewBag.SelectedItemCatDescA = ItemCatDescA;

            }

            return View("Index", cat);
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

            string FileName = string.Empty;
            bool CategoryHaveImage = false;

            if (dto.ImageFile != null)
            {
                string uploads = Path.Combine(_hosting.WebRootPath, "uploads");
                FileName = Guid.NewGuid().ToString() + dto.ImageFile.FileName;
                string FullPath = Path.Combine(uploads, FileName);
                dto.ImageFile.CopyTo(new FileStream(FullPath, FileMode.Create));
                CategoryHaveImage = true;
            }

            var catTable = new MsItemCategory()
            {
                ItemCatDescA = dto.ItemCatDescA,
                ItemCatDescE = dto.ItemCatDescE,
                ImagePath = FileName,
                ImageDescription = dto.ImageDescription,
                ImageDescriptionEn = dto.ImageDescriptionEn,
                WithImage = CategoryHaveImage
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
                ItemCatDescE = cat.ItemCatDescE,
                ImageDescription = cat.ImageDescription,
                ImageDescriptionEn = cat.ImageDescriptionEn,
                ImagePath = cat.ImagePath 
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
            bool CategoryHaveImage = false;

            string FileName = string.Empty;

            if (dto.ImageFile != null)
            {
                string uploads = Path.Combine(_hosting.WebRootPath, "uploads");
                FileName = Guid.NewGuid().ToString() + dto.ImageFile.FileName;
                string FullPath = Path.Combine(uploads, FileName);
                string OldFileName = catFromTable.ImagePath;
                string FullOldPath = string.Empty;
               
                dto.ImageFile.CopyTo(new FileStream(FullPath, FileMode.Create));
                CategoryHaveImage = true;

            }


            catFromTable.ItemCatDescA = dto.ItemCatDescA;
            catFromTable.ItemCatDescE = dto.ItemCatDescE;
            if (!string.IsNullOrEmpty(FileName))
            {
                catFromTable.ImagePath = FileName;
                catFromTable.WithImage = CategoryHaveImage;

            }

            catFromTable.ImageDescription = dto.ImageDescription;
            catFromTable.ImageDescriptionEn = dto.ImageDescriptionEn;

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
