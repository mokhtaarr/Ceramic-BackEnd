using DAL.Models;
using Dashboard_Ecommerce.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using NToastNotify;
using X.PagedList;
using System.IO;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.AspNetCore.Authorization;

namespace Dashboard_Ecommerce.Controllers
{
    [Authorize]
    public class ProductsController : Controller
    {
        private readonly MoDbContext _context;
        private readonly IToastNotification _toastNotification;
        private readonly IWebHostEnvironment hosting;

        public ProductsController(MoDbContext context, IToastNotification toastNotification, IWebHostEnvironment hosting) 
        {
            _context = context;
            _toastNotification = toastNotification;
            this.hosting = hosting;
        }
        public IActionResult Index(int pageIndex = 1, int pageSize = 50)
        {

            var products = (from itemCard in _context.MsItemCards
                            join itemunit in _context.MsItemUnits on itemCard.ItemCardId equals itemunit.ItemCardId
                            join img in _context.MsItemImages on itemCard.ItemCardId equals img.ItemCardId
                            where itemCard.IsSalesStopped == null
                            select new
                            {
                                itemCard.ItemCardId,
                                itemCard.ItemDescA,
                                itemCard.ItemDescE,
                                itemCard.ProductDescA,
                                itemCard.ProductDescE,
                                Price1 = $"{itemunit.Price1:F2}", // تنسيق السعر هنا
                                PurchDisc = $"{itemunit.PurchDisc:F2}", // تنسيق PurchDisc هنا
                                Price3 = $"{itemunit.Price3:F2}", // تنسيق Price3 هنا
                                img.ImgPath,
                                img.ImgPath2,
                                img.ImgPath3,
                                img.ImgPath4,
                                img.ImgPath5,
                                img.ImgPath6,
                            }).ToPagedList(pageIndex,pageSize);


            return View(products);
        }

        public IActionResult Search(string term , int pageIndex = 1, int pageSize = 60)
        {
            var products = (from itemCard in _context.MsItemCards
                            join itemunit in _context.MsItemUnits on itemCard.ItemCardId equals itemunit.ItemCardId
                            join img in _context.MsItemImages on itemCard.ItemCardId equals img.ItemCardId
                            where (itemCard.ItemDescA.Contains(term) || itemCard.ItemDescE.Contains(term)) && itemCard.IsSalesStopped == null
                            select new
                            {
                                itemCard.ItemCardId,
                                itemCard.ItemDescA,
                                itemCard.ItemDescE,
                                itemCard.ProductDescA,
                                itemCard.ProductDescE,
                                itemunit.Price1,
                                itemunit.PurchDisc,
                                itemunit.Price3,
                                img.ImgPath,
                                img.ImgPath2,
                                img.ImgPath3,
                                img.ImgPath4,
                                img.ImgPath5,
                                img.ImgPath6,
                            }).ToPagedList(pageIndex,pageSize);
            if(term != string.Empty)
            {
                ViewBag.term = term;
            }
            return View("Index", products);
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
                Brands = await _context.SrBrands.OrderBy(m=>m.DescA).ToListAsync(),
                Categories = await _context.MsItemCategories.OrderBy(m=>m.ItemCatDescA).ToListAsync()
            };

            return View("ProductForm",viewModel);
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create(ProductDto dto)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        dto.Brands = await _context.SrBrands.OrderBy(m => m.DescA).ToListAsync();
        //        dto.Categories = await _context.MsItemCategories.OrderBy(m => m.ItemCatDescA).ToListAsync();
        //        return View("ProductForm", dto);
        //    }

        //    var uploadPaths = new List<string>();

        //    for (int i = 0; i < 6; i++)
        //    {
        //        var uploadFile = dto.GetType().GetProperty($"UploadFile{i + 1}").GetValue(dto) as IFormFile;

        //        if (uploadFile != null)
        //        {
        //            string fileName = Path.Combine(hosting.WebRootPath, "Products", uploadFile.FileName);
        //            using (var stream = new FileStream(fileName, FileMode.Create))
        //            {
        //                uploadFile.CopyTo(stream);
        //                uploadPaths.Add(uploadFile.FileName);
        //            }
        //        }
        //    }

        //    var prd = new MsItemCard()
        //    {
        //        ItemDescA = dto.ItemDescA,
        //        ItemDescE = dto.ItemDescE,
        //        BrandId = dto.BrandId,
        //        ItemCategoryId = dto.ItemCategoryId,
        //    };

        //    _context.MsItemCards.Add(prd);
        //    _context.SaveChanges();

        //    int newProductId = prd.ItemCardId;

        //    var img = new MsItemImage()
        //    {
        //        ItemCardId = newProductId,
        //        ImgPath = uploadPaths.ElementAtOrDefault(0),
        //        ImgPath2 = uploadPaths.ElementAtOrDefault(1),
        //        ImgPath3 = uploadPaths.ElementAtOrDefault(2),
        //        ImgPath4 = uploadPaths.ElementAtOrDefault(3),
        //        ImgPath5 = uploadPaths.ElementAtOrDefault(4),
        //        ImgPath6 = uploadPaths.ElementAtOrDefault(5)
        //    };

        //    _context.MsItemImages.Add(img);
        //    _context.SaveChanges();

        //    var unit = new MsItemUnit()
        //    {
        //        ItemCardId = newProductId,
        //        Price1 = dto.TotalCost,
        //        PurchDisc = dto.Discount,
        //        Price3 = dto.TotalCost - ((dto.Discount / 100) * dto.TotalCost),
        //    };

        //    _context.MsItemUnits.Add(unit);
        //    _context.SaveChanges();

        //    _toastNotification.AddSuccessToastMessage("Product Created Successfully");

        //    return RedirectToAction(nameof(Index));
        //}


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductDto dto)
        {
            if (!ModelState.IsValid)
            {
                dto.Brands = await _context.SrBrands.OrderBy(m => m.DescA).ToListAsync();
                dto.Categories = await _context.MsItemCategories.OrderBy(m => m.ItemCatDescA).ToListAsync();
                return View("ProductForm", dto);
            }

            string fileName = string.Empty;

            if (dto.UploadFile != null)
            {
                string uploads = Path.Combine(hosting.WebRootPath, "Products");
                fileName = Guid.NewGuid().ToString() + dto.UploadFile.FileName;
                string fullPath = Path.Combine(uploads, fileName);
                dto.UploadFile.CopyTo(new FileStream(fullPath, FileMode.Create));
            }


            string fileName2 = string.Empty;

            if (dto.UploadFile2 != null)
            {
                string uploads = Path.Combine(hosting.WebRootPath, "Products");
                fileName2 = Guid.NewGuid().ToString() + dto.UploadFile2.FileName;
                string fullPath = Path.Combine(uploads, fileName2);
                dto.UploadFile2.CopyTo(new FileStream(fullPath, FileMode.Create));
            }

            string fileName3 = string.Empty;

            if (dto.UploadFile3 != null)
            {
                string uploads = Path.Combine(hosting.WebRootPath, "Products");
                fileName3 = Guid.NewGuid().ToString() + dto.UploadFile3.FileName;
                string fullPath = Path.Combine(uploads, fileName3);
                dto.UploadFile3.CopyTo(new FileStream(fullPath, FileMode.Create));
            }

            string fileName4 = string.Empty;

            if (dto.UploadFile4 != null)
            {
                string uploads = Path.Combine(hosting.WebRootPath, "Products");
                fileName4 = Guid.NewGuid().ToString() + dto.UploadFile4.FileName;
                string fullPath = Path.Combine(uploads, fileName4);
                dto.UploadFile4.CopyTo(new FileStream(fullPath, FileMode.Create));
            }

            string fileName5 = string.Empty;

            if (dto.UploadFile5 != null)
            {
                string uploads = Path.Combine(hosting.WebRootPath, "Products");
                fileName5 = Guid.NewGuid().ToString() + dto.UploadFile5.FileName;
                string fullPath = Path.Combine(uploads, fileName5);
                dto.UploadFile5.CopyTo(new FileStream(fullPath, FileMode.Create));
            }

            string fileName6 = string.Empty;

            if (dto.UploadFile6 != null)
            {
                string uploads = Path.Combine(hosting.WebRootPath, "Products");
                fileName6 = Guid.NewGuid().ToString() + dto.UploadFile6.FileName;
                string fullPath = Path.Combine(uploads, fileName6);
                dto.UploadFile6.CopyTo(new FileStream(fullPath, FileMode.Create));
            }


            var prd = new MsItemCard()
            {
                ItemDescA = dto.ItemDescA,
                ItemDescE = dto.ItemDescE,
                BrandId = dto.BrandId,
                ItemCategoryId = dto.ItemCategoryId,
                ProductDescA = dto.ProductDescA,
                ProductDescE = dto.ProductDescE,
                //QtyPartiation = dto.QtyPartiation,
                //TotalCost = dto.TotalCost,
                //Discount = dto.Discount,
                //ImgPath1 = fileName,
                //FirstPrice = dto.TotalCost - ((dto.Discount / 100) * dto.TotalCost),

            };
            _context.MsItemCards.Add(prd);
            _context.SaveChanges();

            int newProductId = prd.ItemCardId; // احتفظ بمعرف العنصر الجديد

            var img = new MsItemImage()
            {
                ItemCardId = newProductId,
                ImgPath = fileName,
                ImgPath2 = fileName2,
                ImgPath3 = fileName3,
                ImgPath4 = fileName4,
                ImgPath5 = fileName5,
                ImgPath6 = fileName6
            };

            _context.MsItemImages.Add(img);
            _context.SaveChanges();

            var unit = new MsItemUnit()
            {
                ItemCardId = newProductId,
                Price1 = dto.TotalCost,
                PurchDisc = dto.Discount,
                Price3 = dto.TotalCost - ((dto.Discount / 100) * dto.TotalCost),
            };

            _context.MsItemUnits.Add(unit);
            _context.SaveChanges();

            _toastNotification.AddSuccessToastMessage("Product Created Successfully");



            return RedirectToAction(nameof(Index));


        }

        public async Task<IActionResult> Edit(int? ItemCardId)
        {
            if (ItemCardId == null)
                return BadRequest();

            var prd = await _context.MsItemCards.FindAsync(ItemCardId);
            var img = await _context.MsItemImages.FirstOrDefaultAsync(p => p.ItemCardId == ItemCardId);
            var unit = await _context.MsItemUnits.FirstOrDefaultAsync(p => p.ItemCardId == ItemCardId);


            if (prd == null)
                return NotFound();
          
            var productEdit = new ProductDto()
            {
                ItemCardId = prd.ItemCardId, 
                ItemDescA = prd.ItemDescA,
                ItemDescE = prd.ItemDescE,
            // التعديل الخاص بالوصف بتاع المنتج

                ProductDescA = prd.ProductDescA,
                ProductDescE = prd.ProductDescE,
                //QtyPartiation = (int)prd.QtyPartiation,
                TotalCost = (decimal)unit.Price1,
                Discount = (decimal)unit.PurchDisc,
                //TaxItemCode = prd.TaxItemCode,
                BrandId = (int)prd.BrandId,
                ItemCategoryId = (int)prd.ItemCategoryId,
                Brands = await _context.SrBrands.OrderBy(m => m.DescA).ToListAsync(),
                Categories = await _context.MsItemCategories.OrderBy(m => m.ItemCatDescA).ToListAsync(),
                ImgPath = img.ImgPath,
                ImgPath2 = img.ImgPath2,
                ImgPath3 = img.ImgPath3,
                ImgPath4 = img.ImgPath4,
                ImgPath5 = img.ImgPath5,
                ImgPath6 = img.ImgPath6,

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
            var img = await _context.MsItemImages.FirstOrDefaultAsync(p => p.ItemCardId == dto.ItemCardId);
            var unit = await _context.MsItemUnits.FirstOrDefaultAsync(p => p.ItemCardId == dto.ItemCardId);

            if (prd == null)
                return NotFound();

            string FileName = string.Empty;



            if (dto.UploadFile != null)
            {
                string uploads = Path.Combine(hosting.WebRootPath, "Products");
                FileName = Guid.NewGuid().ToString() + dto.UploadFile.FileName;
                string FullPath = Path.Combine(uploads, FileName);

                dto.UploadFile.CopyTo(new FileStream(FullPath, FileMode.Create));

            }


            string FileName2 = string.Empty;

            if (dto.UploadFile2 != null)
            {
                string uploads = Path.Combine(hosting.WebRootPath, "Products");
                FileName2 = Guid.NewGuid().ToString() + dto.UploadFile2.FileName;
                string FullPath = Path.Combine(uploads, FileName2);


                using (FileStream stream = new FileStream(FullPath, FileMode.Create))
                {
                    dto.UploadFile2.CopyTo(stream);
                }
            }


            string FileName3 = string.Empty;

            if (dto.UploadFile3 != null)
            {
                string uploads = Path.Combine(hosting.WebRootPath, "Products");
                FileName3 = Guid.NewGuid().ToString() + dto.UploadFile3.FileName;
                string FullPath = Path.Combine(uploads, FileName3);


                using (FileStream stream = new FileStream(FullPath, FileMode.Create))
                {
                    dto.UploadFile3.CopyTo(stream);
                }
            }

            string FileName4 = string.Empty;

            if (dto.UploadFile4 != null)
            {
                string uploads = Path.Combine(hosting.WebRootPath, "Products");
                FileName4 = Guid.NewGuid().ToString() + dto.UploadFile4.FileName;
                string FullPath = Path.Combine(uploads, FileName4);

               
                using (FileStream stream = new FileStream(FullPath, FileMode.Create))
                {
                    dto.UploadFile4.CopyTo(stream);
                }
            }

            string FileName5 = string.Empty;

            if (dto.UploadFile5 != null)
            {
                string uploads = Path.Combine(hosting.WebRootPath, "Products");
                FileName5 = Guid.NewGuid().ToString() + dto.UploadFile5.FileName;
                string FullPath = Path.Combine(uploads, FileName5);

                

                using (FileStream stream = new FileStream(FullPath, FileMode.Create))
                {
                    dto.UploadFile5.CopyTo(stream);
                }
            }

            string FileName6 = string.Empty;

            if (dto.UploadFile6 != null)
            {
                string uploads = Path.Combine(hosting.WebRootPath, "Products");
                FileName6 = Guid.NewGuid().ToString() + dto.UploadFile6.FileName;
                string FullPath = Path.Combine(uploads, FileName6);

             
                using (FileStream stream = new FileStream(FullPath, FileMode.Create))
                {
                    dto.UploadFile6.CopyTo(stream);
                }

            }
            prd.ItemDescA = dto.ItemDescA;
            prd.ItemDescE = dto.ItemDescE;

            // التعديل الخاص بالوصف 
            prd.ProductDescA = dto.ProductDescA;
            prd.ProductDescE = dto.ProductDescE;

            prd.BrandId = dto.BrandId;
            prd.ItemCategoryId = dto.ItemCategoryId;
            unit.Price1 = dto.TotalCost;
            unit.PurchDisc = dto.Discount;
            unit.Price3 = dto.TotalCost - ((dto.Discount / 100) * dto.TotalCost);
            if (!string.IsNullOrEmpty(FileName))
            {
                img.ImgPath = FileName;
            }
            if (!string.IsNullOrEmpty(FileName2))
            {
                img.ImgPath2 = FileName2;
            }
            if (!string.IsNullOrEmpty(FileName3))
            {
                img.ImgPath3 = FileName3;
            }
            if (!string.IsNullOrEmpty(FileName4))
            {
                img.ImgPath4 = FileName4;
            }
            if (!string.IsNullOrEmpty(FileName5))
            {
                img.ImgPath5 = FileName5;
            }
            if (!string.IsNullOrEmpty(FileName6))
            {
                img.ImgPath6 = FileName6;
            }


            //prd.QtyPartiation = dto.QtyPartiation;
            //prd.TotalCost = dto.TotalCost;
            //prd.Discount = dto.Discount;
            //prd.FirstPrice = dto.TotalCost - ((dto.Discount / 100) * dto.TotalCost);

            _context.SaveChanges();

            _toastNotification.AddSuccessToastMessage("Product Update Successfully");

            return RedirectToAction(nameof(Index));


        }


        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return BadRequest();

            try
            {
                var prd = await _context.MsItemCards.FindAsync(id);

                if (prd == null)
                    return NotFound();

                 prd.IsSalesStopped = true;
                _context.SaveChanges();

                return Ok();





                //var imagesToDelete = await _context.MsItemImages
                //    .Where(p => p.ItemCardId == id)
                //    .ToListAsync();

                //foreach (var img in imagesToDelete)
                //{
                //    // حذف الملف القديم إذا كان موجودًا
                //    if (!string.IsNullOrEmpty(img.ImgPath))
                //    {
                //        string FullPath = Path.Combine(hosting.WebRootPath, "Products", img.ImgPath);
                //        System.IO.File.Delete(FullPath);
                //    }

                //    if (!string.IsNullOrEmpty(img.ImgPath2))
                //    {
                //        string FullPath = Path.Combine(hosting.WebRootPath, "Products", img.ImgPath2);
                //        System.IO.File.Delete(FullPath);
                //    }

                //    if (!string.IsNullOrEmpty(img.ImgPath3))
                //    {
                //        string FullPath = Path.Combine(hosting.WebRootPath, "Products", img.ImgPath3);
                //        System.IO.File.Delete(FullPath);
                //    }

                //    if (!string.IsNullOrEmpty(img.ImgPath4))
                //    {
                //        string FullPath = Path.Combine(hosting.WebRootPath, "Products", img.ImgPath4);
                //        System.IO.File.Delete(FullPath);
                //    }

                //    if (!string.IsNullOrEmpty(img.ImgPath5))
                //    {
                //        string FullPath = Path.Combine(hosting.WebRootPath, "Products", img.ImgPath5);
                //        System.IO.File.Delete(FullPath);
                //    }


                //    if (!string.IsNullOrEmpty(img.ImgPath6))
                //    {
                //        string FullPath = Path.Combine(hosting.WebRootPath, "Products", img.ImgPath6);
                //        System.IO.File.Delete(FullPath);
                //    }


                //    _context.MsItemImages.Remove(img);
                //}

                // حذف جميع الصفوف من جدول الصور
                //_context.MsItemImages.RemoveRange(imagesToDelete);

                //var units = await _context.MsItemUnits
                //    .Where(p => p.ItemCardId == id)
                //    .ToListAsync();
                //_context.MsItemUnits.RemoveRange(units);

                //// حذف الصف من جدول البيانات الرئيسي
                //_context.MsItemCards.Remove(prd);

                //await _context.SaveChangesAsync();

                //return Ok();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred: " + ex.Message);
                if (ex.InnerException != null)
                {
                    Console.WriteLine("Inner Exception: " + ex.InnerException.Message);
                }
                return StatusCode(500);
            }
        }
        [HttpGet("View")]
        public IActionResult getDataFromView()
        {
            return Ok(_context.MS_ItemCardView.ToList());
        }

        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //        return BadRequest();
        //    var prd = await _context.MsItemCards.FindAsync(id);
        //    //var img = await _context.MsItemImages.FirstOrDefaultAsync(p => p.ItemCardId == id);

        //    var imagesToDelete = await _context.MsItemImages
        //           .Where(p => p.ItemCardId == id)
        //           .ToListAsync();

        //    foreach (var img in imagesToDelete)
        //    {
        //        // حذف الملف القديم إذا كان موجودًا
        //        if (!string.IsNullOrEmpty(img.ImgPath))
        //        {
        //            string FullOldPath = Path.Combine(uploads, img.ImgPath);
        //            System.IO.File.Delete(FullOldPath);
        //        }
        //        // تنفيذ عمليات الحذف أو التعديل الأخرى التي تحتاجها
        //        _context.MsItemImages.Remove(img);
        //    }

        //    await _context.SaveChangesAsync();

        //    var unit = await _context.MsItemUnits.FirstOrDefaultAsync(p => p.ItemCardId == id);

        //    if (prd == null)
        //        return NotFound();

        //    _context.MsItemCards.Remove(prd);
        //    _context.MsItemImages.Remove(img);
        //    _context.MsItemUnits.Remove(unit);  

        //    _context.SaveChanges();
        //    return Ok();
        //}


    }

}
