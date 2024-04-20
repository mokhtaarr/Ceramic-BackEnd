using DAL.Models;
using Dashboard_Ecommerce.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NToastNotify;
using X.PagedList;

namespace Dashboard_Ecommerce.Controllers
{
    public class OurCustomerController : Controller
    {
        private readonly MoDbContext _db;
        private readonly IToastNotification _toastNotification;

        public OurCustomerController(MoDbContext db, IToastNotification toastNotification)
        {
            _db = db;
            _toastNotification = toastNotification;
        }

        public async Task<IActionResult> Index(int pageIndex = 1, int pageSize = 50)
        { 
            var OurCustomers = await (
                     from customer in _db.MsCustomers
                     join category in _db.MsCustomerCategories on customer.CustomerCatId equals category.CustomerCatId into joinedCategory
                     from cat in joinedCategory.DefaultIfEmpty() // هنا يتم تعيين LEFT JOIN
                     where (bool)customer.IsWebsite && customer.DeletedAt == null
                     select new
                      {
                         customer.CustomerId,
                         customer.CustomerDescA,
                         customer.CustomerCode , 
                         customer.Tel,
                         customer.Address,
                         customer.Address2,
                         customer.Address3,
                         customer.AddField1,
                         customer.AddField2,
                         customer.AddField3,
                         customer.Remarks,
                         CatDescA = cat != null ? cat.CatDescA : null // استخدام null إذا لم يتم العثور على تطابق في LEFT JOIN
                     }
                  ).ToPagedListAsync(pageIndex, pageSize);
            return View(OurCustomers);
        }

        public async Task<IActionResult> search(int pageIndex = 1, int pageSize = 50,string phone = "")
        {

            if(phone != string.Empty)
            {
                ViewBag.term = phone;
            }

            var OurCustomers = await (
                     from customer in _db.MsCustomers
                     join category in _db.MsCustomerCategories on customer.CustomerCatId equals category.CustomerCatId into joinedCategory
                     from cat in joinedCategory.DefaultIfEmpty() // هنا يتم تعيين LEFT JOIN
                     where (bool)customer.IsWebsite && customer.DeletedAt == null && customer.Tel == phone
                     select new
                     {
                         customer.CustomerId,
                         customer.CustomerDescA,
                         customer.CustomerCode,
                         customer.Tel,
                         customer.Address,
                         customer.Address2,
                         customer.Address3,
                         customer.AddField1,
                         customer.AddField2,
                         customer.AddField3,
                         customer.Remarks,
                         CatDescA = cat != null ? cat.CatDescA : null // استخدام null إذا لم يتم العثور على تطابق في LEFT JOIN
                     }
                  ).ToPagedListAsync(pageIndex, pageSize);
            return View(OurCustomers);
        }


        public async Task<IActionResult> Edit(int? customerId)
        {
            if (customerId == null)
                return BadRequest();

            var customer = await _db.MsCustomers.FindAsync(customerId);

            if (customer == null)
                return NotFound();

            var dto = new CustomerDto
            {
                CustomerId = customer.CustomerId,
                CustomerDescA = customer.CustomerDescA,
                CustomerCode = customer.CustomerCode,
                Tel = customer.Tel,
                CustomerCatId = customer.CustomerCatId.HasValue ? (int)customer.CustomerCatId : 0,
                CustomerCategory = await _db.MsCustomerCategories.OrderBy(m=>m.CatDescA).ToListAsync(),
                Address = customer.Address,
                Address2 = customer.Address2,
                Address3 = customer.Address3,
                Remarks = customer.Remarks,
                AddField1 = customer.AddField1,
                AddField2 = customer.AddField2,
                AddField3 = customer.AddField3,

            };

            return View("Edit", dto);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(CustomerDto dto)
        {
            if (!ModelState.IsValid)
            {
                dto.CustomerCategory = await _db.MsCustomerCategories.OrderBy(c => c.CatDescA).ToListAsync();
                return View("Edit",dto);
            }

            var customer = await _db.MsCustomers.FindAsync(dto.CustomerId);
            if (customer == null)
                return NotFound();

            customer.CustomerDescA = dto.CustomerDescA;
            customer.CustomerCode = dto.CustomerCode;
            customer.Tel = dto.Tel;
            customer.CustomerCatId = dto.CustomerCatId;
            customer.Address = dto.Address;
            customer.Address2 = dto.Address2;
            customer.Address3 = dto.Address3;
            customer.Remarks = dto.Remarks;
            customer.AddField1 = dto.AddField1;
            customer.AddField2 = dto.AddField2;
            customer.AddField3 = dto.AddField3;

            _db.SaveChanges();
            _toastNotification.AddSuccessToastMessage("Customer Updated Successfully");


            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> delete(int id)
        {
            if (id == 0)
            {
                _toastNotification.AddErrorToastMessage("Bad Request");
                return RedirectToAction(nameof(Index));
            }

            MsCustomer customer = await _db.MsCustomers.FindAsync(id);

            if (customer == null)
            {
                 _toastNotification.AddErrorToastMessage("customer not exisit");
                return RedirectToAction(nameof(Index));
            }

            customer.DeletedAt = DateTime.Now;
             await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }
    }
}
