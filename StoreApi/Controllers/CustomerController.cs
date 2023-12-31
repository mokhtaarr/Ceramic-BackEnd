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

            MsCustomer ExistingCustomer = await  _db.MsCustomers.FirstOrDefaultAsync(c=>c.CustomerCode== dto.CustomerCode);

            if (ExistingCustomer != null)
            {
                return Ok(ExistingCustomer.CustomerId);
            }

            MsCustomer customer = new MsCustomer()
            {
                CustomerCode = dto.CustomerCode,
                CustomerDescA = dto.CustomerDescA,
                CustomerDescE = dto.CustomerDescE,
                CurrencyId = clientCurrency.CurrencyId,
                Tel = dto.Tel,
                Address = dto.Address,
                Address2 = dto.Address2,
                Address3 = dto.Address3,
                AddField1 = dto.AddField1,
                AddField2 = dto.AddField2,
                AddField3 = dto.AddField3,
                Remarks = dto.Remarks,
                IsWebsite = true
            };

            await _db.MsCustomers.AddAsync(customer);
            _db.SaveChanges();
            return Ok(customer.CustomerId);


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

        }

    }
}
