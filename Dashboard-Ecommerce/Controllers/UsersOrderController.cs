using DAL.Models;
using Dashboard_Ecommerce.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NToastNotify;
using System.Security.Cryptography;
using X.PagedList;

namespace Dashboard_Ecommerce.Controllers
{
    [Authorize]
    public class UsersOrderController : Controller
    {

        private readonly MoDbContext _db;

        public UsersOrderController(MoDbContext db)
        {
                _db= db;
        }



        //public IActionResult Index(int pageIndex = 1, int pageSize = 5)
        //{
        //    var Orders =  (from orderHeader in _db.MsSalesOffers
        //                        join orderDetail in _db.MsSalesOfferItemCards on orderHeader.SalesOfferId equals orderDetail.SalesOfferId
        //                        join customer in _db.MsCustomers on orderHeader.CustomerId equals customer.CustomerId
        //                        join itemCard in _db.MsItemCards on orderDetail.ItemCardId equals itemCard.ItemCardId

        //                        group new { orderHeader, orderDetail, customer, itemCard } by orderHeader.SalesOfferId into grouped
        //                        select new OrderDataDto
        //                        {
        //                            SalesOfferId = grouped.Key,
        //                            NotPaid = grouped.FirstOrDefault().orderHeader.NotPaid.GetValueOrDefault(),
        //                            CreatedAt = grouped.FirstOrDefault().orderHeader.CreatedAt.GetValueOrDefault(),
        //                            CustomerDescA = grouped.FirstOrDefault().customer.CustomerDescA,
        //                            Details = grouped.Select(g => new OrderDetail
        //                            {
        //                                ItemCardId = (int)g.orderDetail.ItemCardId,
        //                                ItemDescA = g.itemCard.ItemDescA,
        //                                Quantity = (int)g.orderDetail.Quantity,
        //                                Price = g.orderDetail.Price
        //                            }).ToList()
        //                        }).ToPagedList(pageIndex, pageSize);

        //    return View(Orders);
        //}



        //public async Task<IActionResult> Index()
        //{
        //    var Orders = await (from orderHeader in _db.MsSalesOffers
        //                        join orderDetail in _db.MsSalesOfferItemCards on orderHeader.SalesOfferId equals orderDetail.SalesOfferId
        //                        join customer in _db.MsCustomers on orderHeader.CustomerId equals customer.CustomerId
        //                        join itemCard in _db.MsItemCards on orderDetail.ItemCardId equals itemCard.ItemCardId
        //                        group new { orderHeader, orderDetail, customer, itemCard } by orderHeader.SalesOfferId into grouped
        //                        select new OrderDataDto
        //                        {
        //                            SalesOfferId = grouped.Key,
        //                            NotPaid = grouped.FirstOrDefault().orderHeader.NotPaid,
        //                            CreatedAt = grouped.FirstOrDefault().orderHeader.CreatedAt,
        //                            CustomerDescA = grouped.FirstOrDefault().customer.CustomerDescA,
        //                            CustomerCode = grouped.FirstOrDefault().customer.CustomerCode,
        //                            Details = grouped.Select(g => new OrderDetail
        //                            {
        //                                ItemCardId = (int)g.orderDetail.ItemCardId,
        //                                ItemDescA = g.itemCard.ItemDescA,
        //                                Quantity = (int)g.orderDetail.Quantity,
        //                                Price = g.orderDetail.Price
        //                            }).ToList()
        //                        })
        //                        .OrderByDescending(o => o.CreatedAt)  // ترتيب حسب CreatedAt بترتيب تنازلي
        //                        .ToListAsync();

        //    return View(Orders);
        //}

        public async Task<IActionResult> Index(int page = 1, int pageSize = 50)
        {
            var Orders = await (from orderHeader in _db.MsSalesOffers
                                join orderDetail in _db.MsSalesOfferItemCards on orderHeader.SalesOfferId equals orderDetail.SalesOfferId
                                join customer in _db.MsCustomers on orderHeader.CustomerId equals customer.CustomerId
                                join itemCard in _db.MsItemCards on orderDetail.ItemCardId equals itemCard.ItemCardId
                                where orderHeader.CloseDate == null
                                group new { orderHeader, orderDetail, customer, itemCard } by orderHeader.SalesOfferId into grouped
                                select new OrderDataDto
                                {
                                    SalesOfferId = grouped.Key,
                                    NotPaid = grouped.FirstOrDefault().orderHeader.NotPaid,
                                    CreatedAt = grouped.FirstOrDefault().orderHeader.CreatedAt,
                                    CustomerDescA = grouped.FirstOrDefault().customer.CustomerDescA,
                                    CustomerCode = grouped.FirstOrDefault().customer.CustomerCode,
                                    Details = grouped.Select(g => new OrderDetail
                                    {
                                        ItemCardId = (int)g.orderDetail.ItemCardId,
                                        ItemDescA = g.itemCard.ItemDescA,
                                        Quantity = (int)g.orderDetail.Quantity,
                                        Price = g.orderDetail.Price
                                    }).ToList()
                                })
                                .OrderByDescending(o => o.CreatedAt)  // ترتيب حسب CreatedAt بترتيب تنازلي
                                .Skip((page - 1) * pageSize)
                                .Take(pageSize)
                                .ToListAsync();

            var totalItems = await _db.MsSalesOffers.CountAsync();
            var totalPages = (int)Math.Ceiling((double)totalItems / pageSize);

            var viewModel = new PaginatedViewModel<OrderDataDto>
            {
                Items = Orders,
                CurrentPage = page,
                PageSize = pageSize,
                TotalItems = totalItems,
                TotalPages = totalPages
            };

            return View(viewModel);
        }


        public async Task<IActionResult> search(int page = 1, int pageSize = 50 , string term = "")
        {

            if(term != string.Empty)
            {
                ViewBag.term = term;
            }

            var Orders = await (from orderHeader in _db.MsSalesOffers
                                join orderDetail in _db.MsSalesOfferItemCards on orderHeader.SalesOfferId equals orderDetail.SalesOfferId
                                join customer in _db.MsCustomers on orderHeader.CustomerId equals customer.CustomerId
                                join itemCard in _db.MsItemCards on orderDetail.ItemCardId equals itemCard.ItemCardId
                                where orderHeader.CloseDate == null && customer.CustomerCode == term
                                group new { orderHeader, orderDetail, customer, itemCard } by orderHeader.SalesOfferId into grouped
                                select new OrderDataDto
                                {
                                    SalesOfferId = grouped.Key,
                                    NotPaid = grouped.FirstOrDefault().orderHeader.NotPaid,
                                    CreatedAt = grouped.FirstOrDefault().orderHeader.CreatedAt,
                                    CustomerDescA = grouped.FirstOrDefault().customer.CustomerDescA,
                                    CustomerCode = grouped.FirstOrDefault().customer.CustomerCode,
                                    Details = grouped.Select(g => new OrderDetail
                                    {
                                        ItemCardId = (int)g.orderDetail.ItemCardId,
                                        ItemDescA = g.itemCard.ItemDescA,
                                        Quantity = (int)g.orderDetail.Quantity,
                                        Price = g.orderDetail.Price
                                    }).ToList()
                                })
                                .OrderByDescending(o => o.CreatedAt)  // ترتيب حسب CreatedAt بترتيب تنازلي
                                .Skip((page - 1) * pageSize)
                                .Take(pageSize)
                                .ToListAsync();

            var totalItems = await _db.MsSalesOffers.CountAsync();
            var totalPages = (int)Math.Ceiling((double)totalItems / pageSize);

            var viewModel = new PaginatedViewModel<OrderDataDto>
            {
                Items = Orders,
                CurrentPage = page,
                PageSize = pageSize,
                TotalItems = totalItems,
                TotalPages = totalPages
            };

            return View("Index", viewModel);
        }

        public async Task<IActionResult> OrderAccept(int? id)
        {
            var OrderRecord = await _db.MsSalesOffers.FindAsync(id);
            if (OrderRecord == null)
                return NotFound("لايوجد ريكورد بهذا الرقم");
            OrderRecord.CloseDate = DateTime.Now;
             _db.SaveChanges();
            
            return Ok();
        }
    }
}
