using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StoreApi.Dtos;
using StoreApi.Extensions;

namespace StoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly MoDbContext _db;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public OrderController(MoDbContext db , IWebHostEnvironment webHostEnvironment)
        {
            _db = db;
            _webHostEnvironment = webHostEnvironment;
        }

        [HttpPost("CreateOrderHeader")]
        public IActionResult CreateOrderHeader(OrderHeaderDto dto)
        {
            var book = from counter in _db.SysCounters
                       where counter.BookId == dto.Header_BookId && counter.TrIdName == "SalesOfferId"
                       select counter.Counter;

            //var getBookId = _db.SysBooks.FirstOrDefault(b => b.BookId == dto.Header_BookId);

            var salesOrder = new MsSalesOffer
            {
                BookId = dto.Header_BookId,
                TermId = dto.Header_TermId,
                CurrencyId = dto.Header_CurrencyId,
                CustomerId = dto.Header_CustomerId,
                RectSourceType = 1,
                CreatedBy = dto.Header_CreatedBy,
                CreatedAt = DateTime.Now,
                NotPaid = dto.Header_NotPaid / 100,
                InvDueDate = DateTime.Now.Date,
                TrDate = DateTime.Now,
                TaxesId1 = dto.Header_TaxesId1 == 0 ? null : dto.Header_TaxesId1,
                TaxesId2 = dto.Header_TaxesId2 == 0 ? null : dto.Header_TaxesId2,
                TaxesId3 = dto.Header_TaxesId3 == 0 ? null : dto.Header_TaxesId3,
                Email = dto.Email,
                IsWebsite = true

                //Remarks = dto.Remarks,
                //Rate = dto.Header_Rate,
                //InvTotal = dto.Header_InvTotal,
                //DiscAmount = dto.Header_DiscAmount,
                //DiscPercent = dto.Header_DiscPercent,
                //DiscAmount2 = dto.Header_DiscPercent2,
                //DiscPercent2 = dto.Header_DiscPercent2,
                //TotalItemTax1 = dto.Header_TotalItemTax1,
                //TotalItemTax2 = dto.Header_TotalItemTax2,
                //TotalItemTax3 = dto.Header_TotalItemTax3,
                //TaxValue1 = dto.Header_TaxValue1,
                //TaxValue2 = dto.Header_TaxValue2,
                //TaxValue3 = dto.Header_TaxValue3,
                // تعديلات يوم  لما دخلت مع مصطفي ميتنج الصبح 9/10
                //PriceAfterTax = dto.Header_PriceAfterTax,
                //PaidPriceVisa = dto.Header_PaidPriceVisa,
                //ExpenValue = dto.ExpenValue,
                // تعديلات يوم  لما دخلت مع مصطفي ميتنج الصبح 9/10
                // NetPrice = PriceAfterTax + ExpenseValue
                //فى حالة النقدى 0        
                //PaidPrice = NetPrice - PaidVisa
                //فى حالة الأجل 1
                //NetPrice = dto.Header_PriceAfterTax + dto.ExpenValue,
                //InvoiceType = (byte?)dto.InvoiceType,
                //PaidPrice = dto.InvoiceType == 0 ? (dto.Header_PriceAfterTax + dto.ExpenValue) - dto.Header_PaidPriceVisa : dto.Header_PaidPrice,
                //NotPaid = dto.InvoiceType == 1 ? (dto.Header_PriceAfterTax + dto.ExpenValue) - dto.Header_PaidPriceVisa - dto.Header_PaidPrice : 0,
                //PaidPrice = dto.Header_PaidPrice,
                //AddField3 = dto.AddField3,
                //StoreId = dto.StoreId,
                //  added on 1-8-2023
                //EmpId = empid.EmpId

            };

            salesOrder.TrNo = (int)book.FirstOrDefault() + 1;


            _db.MsSalesOffers.Add(salesOrder);
            _db.SaveChanges();

            var Counter = _db.SysCounters.FirstOrDefault(x => x.BookId == dto.Header_BookId);
            Counter.Counter = salesOrder.TrNo;

            _db.SaveChanges();

            foreach (var item in dto.OrderDetails)
            {
                var itmType = _db.MsItemCards.Find(item.ItemCardId);

                _db.MsSalesOfferItemCards.Add(new MsSalesOfferItemCard()
                {
                    SalesOfferId = salesOrder.SalesOfferId,
                    ItemCardId = item.ItemCardId,
                    Price = item.Price,
                    Quantity = item.Quantity,
                    ItemType = itmType.ItemType,
                    TaxesId1 = item.Detail_TaxesId1 == 0 ? null : item.Detail_TaxesId1,
                    TaxesId2 = item.Detail_TaxesId2 == 0 ? null : item.Detail_TaxesId2,
                    TaxesId3 = item.Detail_TaxesId3 == 0 ? null : item.Detail_TaxesId3,
                    Tax1IsAccomulative = item.Detail_TaxesId1 == 0 ? null : item.Tax1IsAccomulative,
                    Tax2IsAccomulative = item.Detail_TaxesId2 == 0 ? null : item.Tax2IsAccomulative,
                    Tax3IsAccomulative = item.Detail_TaxesId3 == 0 ? null : item.Tax3IsAccomulative,
                });
            }

            _db.SaveChanges();

            var respone = new
            {
                SalesOfferId = salesOrder.SalesOfferId,
                message = "تم اضافه الطلب بنجاح"
            };

            return Ok(respone);
        }

        [HttpGet("GetUserOrders")]
        public async Task<IActionResult> GetUserOrders(string email)
        {

            var ExistingEmail = _db.MsSalesOffers.Where(s => s.Email == email);
          
            if(!ExistingEmail.Any())
            {
                return Ok();
            }


            var Orders = await (from orderHeader in _db.MsSalesOffers 
                                join orderDetail in _db.MsSalesOfferItemCards on orderHeader.SalesOfferId equals orderDetail.SalesOfferId
                                join itemCard in _db.MsItemCards on orderDetail.ItemCardId equals itemCard.ItemCardId
                                where orderHeader.Email == email
                                group new { orderHeader, orderDetail, itemCard } by orderHeader.SalesOfferId into grouped
                                select new OrderDataDto
                                {
                                    SalesOfferId = grouped.Key,
                                    NotPaid = grouped.FirstOrDefault().orderHeader.NotPaid,
                                    CreatedAt = grouped.FirstOrDefault().orderHeader.CreatedAt,
                                    Details = grouped.Select(g => new OrderDetailDataDto
                                    {
                                        ItemCardId = (int)g.orderDetail.ItemCardId,
                                        ItemDescA = g.itemCard.ItemDescA,
                                        ItemDescE = g.itemCard.ItemDescE,
                                        Quantity = (int)g.orderDetail.Quantity,
                                        Price = g.orderDetail.Price
                                    }).ToList()
                                })
                                .OrderByDescending(o => o.CreatedAt)  // ترتيب حسب CreatedAt بترتيب تنازلي
                                .ToListAsync();


            return Ok(Orders);

        }

        

        [HttpPost("AddingUnvaliableProduct")]
        public async Task<IActionResult> AddingUnvaliableProduct([FromForm]UnvaliableProductDto dto)
        {
            try
            {
                var prd = new UnavailableProduct
                {
                    ProductNameAr = dto.ProductNameAr,
                    Price = dto.Price,
                    ProductDescA = dto.ProductDescA,
                    Phone=dto.Phone

                };

                _db.UnavailableProducts.Add(prd);
                await _db.SaveChangesAsync();

                if (dto.Image != null && dto.Image.Length > 0)
                {
                    var uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "UnvaliabProducts"); // اسم المجلد داخل wwwroot
                    var cleanFileName = dto.Image.FileName.Replace("-", "");

                    var uniqueFileName = Guid.NewGuid().ToString() + "_" + cleanFileName;
                    var filePath = Path.Combine(uploadsFolder, uniqueFileName);

                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        await dto.Image.CopyToAsync(fileStream);
                    }

                    // قم بتحديث اسم الصورة في الحقل المضاف للـ SrComplaint
                    prd.Image = uniqueFileName;

                    await _db.SaveChangesAsync(); // أعد حفظ التغييرات بما في ذلك اسم الصورة
                }

                return Ok();

            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }



    }
}
