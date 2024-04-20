using DAL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Dashboard_Ecommerce.Controllers
{
    public class DiscountController : Controller
    {
        private readonly MoDbContext _db;
        public DiscountController(MoDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult>  Index()
        {
            MsSalesItemsOffer DiscountDescription = await _db.MsSalesItemsOffers
                .Select(item => new MsSalesItemsOffer { PromoOfferId = item.PromoOfferId , Name1 = item.Name1, Name2 = item.Name2 })
                .FirstOrDefaultAsync();


            return View(DiscountDescription);
        }


        public async Task<IActionResult> Edit(int PromoOfferId)
        {
            MsSalesItemsOffer getRecord = await _db.MsSalesItemsOffers.FindAsync(PromoOfferId);

            return View(getRecord);
        }


        [HttpPost]
        public async Task<IActionResult> Edit(MsSalesItemsOffer offer)
        {
            if (offer == null) return BadRequest("oblect is empty");

            MsSalesItemsOffer getRecord = await _db.MsSalesItemsOffers.FindAsync(offer.PromoOfferId);

            if(getRecord == null) return NotFound("i do not found any record with this id" );


            getRecord.Name1 = offer.Name1;
            getRecord.Name2 = offer.Name2;

            _db.SaveChanges();

            return RedirectToAction("index");
             
            
        }
    }
}
