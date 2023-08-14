using DAL.Models;
using Dashboard_Ecommerce.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using NToastNotify;
using X.PagedList;
using System.IO;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace Dashboard_Ecommerce.Controllers
{
    public class ProductsController : Controller
    {
        private readonly MoDbContext _context;
        private readonly IToastNotification _toastNotification;
        private readonly IHostingEnvironment hosting;

        public ProductsController(MoDbContext context, IToastNotification toastNotification,IHostingEnvironment hosting) 
        {
            _context = context;
            _toastNotification = toastNotification;
            this.hosting = hosting;
        }
        public IActionResult Index(int pageIndex = 1 , int pageSize = 20)
        {
            var products =  _context.MsItemCards.ToPagedList(pageIndex, pageSize);
            return View(products);
        }

        public async Task<IActionResult> GetFinishedProducts()
        {
            var FinishedProduct = await _context.MsItemCards.Where(p => p.QtyPartiation <= 0).ToListAsync();

            return View("FinishedProduct", FinishedProduct);
        }

        public async Task<IActionResult> GetProductsWithOffer()
        {
            var productsWithOffer = await _context.MsItemCards.Where(p => p.Discount > 0).ToListAsync();
            return View("productsWithOffer", productsWithOffer);
        }

        public async Task<IActionResult> GetProductsWithOutOffer()
        {
            var productsWithOffer = await _context.MsItemCards.Where(p => p.Discount == 0).ToListAsync();
            return View("productsWithOutOffer", productsWithOffer);
        }
        public async Task<IActionResult> Create()
        {
            var viewModel = new ProductDto()
            {
                Brands = await _context.SrBrands.OrderBy(m=>m.DescE).ToListAsync(),
                Categories = await _context.MsItemCategories.OrderBy(m=>m.ItemCatDescE).ToListAsync()
            };

            return View("ProductForm",viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductDto dto)
        {
            if (!ModelState.IsValid)
            {
                dto.Brands = await _context.SrBrands.OrderBy(m => m.DescE).ToListAsync();
                dto.Categories = await _context.MsItemCategories.OrderBy(m => m.ItemCatDescE).ToListAsync();
                return View("ProductForm", dto);
            }
            var files = Request.Form.Files;

            string fileName = string.Empty;

            if(dto.UploadFile != null)
            {
                string uploads = Path.Combine(hosting.WebRootPath, "uploads");
                fileName = dto.UploadFile.FileName;
                string fullPath = Path.Combine(uploads,fileName);
                dto.UploadFile.CopyTo(new FileStream(fullPath,FileMode.Create));
            }

            if(!files.Any())
            {
                dto.Brands = await _context.SrBrands.OrderBy(m => m.DescE).ToListAsync();
                dto.Categories = await _context.MsItemCategories.OrderBy(m => m.ItemCatDescE).ToListAsync();
                ModelState.AddModelError("TaxItemCode", "Please select Product image !");
                return View("ProductForm", dto);
            }

            var poster = files.FirstOrDefault();
            var allowedExtenstions = new List<string> { ".jpg",".png"};

            if(!allowedExtenstions.Contains(Path.GetExtension(poster.FileName).ToLower()))
            {
                dto.Brands = await _context.SrBrands.OrderBy(m => m.DescE).ToListAsync();
                dto.Categories = await _context.MsItemCategories.OrderBy(m => m.ItemCatDescE).ToListAsync();
                ModelState.AddModelError("TaxItemCode", "only png or jpg images allowed !");
                return View("ProductForm", dto);
            }

            if(poster.Length > 1048576)
            {
                dto.Brands = await _context.SrBrands.OrderBy(m => m.DescE).ToListAsync();
                dto.Categories = await _context.MsItemCategories.OrderBy(m => m.ItemCatDescE).ToListAsync();
                ModelState.AddModelError("TaxItemCode", "poster cannot be more than 1 MB!");
                return View("ProductForm", dto);    
            }

            using var dataStream = new MemoryStream();

            await poster.CopyToAsync(dataStream);

           

            var prd = new MsItemCard()
            {
                ItemDescA = dto.ItemDescA,
                ItemDescE = dto.ItemDescE,
                BrandId = dto.BrandId,
                ItemCategoryId = dto.ItemCategoryId,
                QtyPartiation= dto.QtyPartiation,
                TotalCost = dto.TotalCost,
                Discount = dto.Discount,
                ImgPath1 = fileName,
                FirstPrice = dto.TotalCost - ((dto.Discount / 100) * dto.TotalCost),
                TaxItemCode = "/images/products/" + poster.FileName,

            };

            _context.MsItemCards.Add(prd);
            _context.SaveChanges();

            _toastNotification.AddSuccessToastMessage("Product Created Successfully");



            return RedirectToAction(nameof(Index));


        }

        public async Task<IActionResult> Edit(int? ItemCardId)
        {
            if (ItemCardId == null)
                return BadRequest();

            var prd = await _context.MsItemCards.FindAsync(ItemCardId);

            if (prd == null)
                return NotFound();
          
            var productEdit = new ProductDto()
            {
                ItemCardId = prd.ItemCardId, 
                ItemDescA = prd.ItemDescA,
                ItemDescE = prd.ItemDescE,
                QtyPartiation = (int)prd.QtyPartiation,
                TotalCost = (decimal)prd.TotalCost,
                Discount = (decimal)prd.Discount,
                TaxItemCode = prd.TaxItemCode,
                BrandId = (int)prd.BrandId,
                ItemCategoryId = (int)prd.ItemCategoryId,
                Brands = await _context.SrBrands.OrderBy(m => m.DescE).ToListAsync(),
                Categories = await _context.MsItemCategories.OrderBy(m => m.ItemCatDescE).ToListAsync()

            };

            return View("ProductEdit", productEdit);
            
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ProductDto dto)
        {
            if (!ModelState.IsValid)
            {

                dto.Brands = await _context.SrBrands.OrderBy(m => m.DescE).ToListAsync();
                dto.Categories = await _context.MsItemCategories.OrderBy(m => m.ItemCatDescE).ToListAsync();
                return View("ProductEdit", dto);
            }
            var prd = await _context.MsItemCards.FindAsync(dto.ItemCardId);

            if (prd == null)
                return NotFound();
            //QtyPartiation = dto.QtyPartiation,
            //    TotalCost = dto.TotalCost,
            //    Discount = dto.Discount,
            //    FirstPrice = dto.TotalCost - ((dto.Discount / 100) * dto.TotalCost),

            prd.ItemDescA = dto.ItemDescA;
            prd.ItemDescE = dto.ItemDescE;
            prd.BrandId = dto.BrandId;
            prd.ItemCategoryId = dto.ItemCategoryId;
            prd.QtyPartiation = dto.QtyPartiation;
            prd.TotalCost = dto.TotalCost;
            prd.Discount = dto.Discount;
            prd.FirstPrice = dto.TotalCost - ((dto.Discount / 100) * dto.TotalCost);

            _context.SaveChanges();

            _toastNotification.AddSuccessToastMessage("Product Update Successfully");

            return RedirectToAction(nameof(Index));


        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return BadRequest();
            var prd = await _context.MsItemCards.FindAsync(id);
            if (prd == null)
                return NotFound();

            _context.MsItemCards.Remove(prd);
            _context.SaveChanges();
            return Ok();
        }


    }

}
