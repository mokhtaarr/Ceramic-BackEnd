using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace StoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
        private readonly MoDbContext _db;
        public DiscountController(MoDbContext db)
        {
            _db = db;
        }


        [HttpGet]
        public async Task<IActionResult> GetDiscount()
        {
            MsSalesItemsOffer msSalesItemsOffer = await _db.MsSalesItemsOffers.Select(d => new MsSalesItemsOffer { Name1 = d.Name1, Name2 = d.Name2 }).FirstOrDefaultAsync();

            return Ok(msSalesItemsOffer);
        }
    }
}
