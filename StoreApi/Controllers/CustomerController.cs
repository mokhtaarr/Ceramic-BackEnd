using DAL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreApi.Dtos;

namespace StoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly MoDbContext _db;

        public CustomerController(MoDbContext db)
        {
            _db = db;   
        }

        [HttpPost]
        public async Task<IActionResult> AddCustomer(AddCustomerDto dto)
        {
            var clientCurrency = _db.MsCurrencies.Where(p => (bool)p.DefualtCurrency).FirstOrDefault();


            var customer = new MsCustomer()
            {
                CustomerCode = dto.CustomerCode,
                CustomerDescA = dto.CustomerDescA,
                CustomerDescE = dto.CustomerDescE,
                CurrencyId = clientCurrency.CurrencyId,
                Tel = dto.Tel,
                Address = dto.Address,
                IsWebsite = true
            };

            await _db.MsCustomers.AddAsync(customer);
            _db.SaveChanges();

            //var customerAccountIds = _db.MsPossettings.Select(p => new
            //{
            //    CustomerAccountId = p.CustomerAccountId
            //});

            //var POOSSettingCustomerAccountId = customerAccountIds.FirstOrDefault()?.CustomerAccountId;

            //var accountChart = _db.CalAccountCharts.FirstOrDefault(c => c.AccountId == POOSSettingCustomerAccountId);

            //var Account = new CalCustAccount()
            //{
            //    AccountNameA = accountChart.AccountNameA + "-" + customer.CustomerDescA,
            //    AccountNameE = accountChart.AccountNameE + "-" + customer.CustomerDescE,
            //    AccountDescription = "BasicAccCode",
            //    CustomerId = customer.CustomerId,
            //    AccountId = POOSSettingCustomerAccountId,
            //    AccountCode = customer.CustomerCode + "-" + accountChart.AccountCode,
            //    IsInUse = true,
            //    IsPrimeAccount = true,
            //};
            //await _db.CalCustAccounts.AddAsync(Account);
            //_db.SaveChanges();

            return Ok(customer.CustomerId);
        }

    }
}
