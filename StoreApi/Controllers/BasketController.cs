using AutoMapper;
using DAL.interfaces;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StoreApi.Dtos;

namespace StoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketController : ControllerBase
    {
        private readonly IBasketRepository _basketRepository;
        private readonly IMapper _mapper;

        public BasketController(IBasketRepository basketRepository, IMapper mapper)
        {
            _basketRepository = basketRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<EcomCustomerBasket>> GetBasketById(string id)
        {
            var basket = await _basketRepository.GetBasketAsync(id);
            return Ok(basket ?? new EcomCustomerBasket(id));
        }

        [HttpPost]
        public async Task<ActionResult<EcomCustomerBasket>> UpdateBasket(EcomCustomerBasketDto basket)
        {
            var customerBasket = _mapper.Map<EcomCustomerBasket>(basket);
            var updatedBasket = await _basketRepository.UpdateBasketAsync(customerBasket);
            return Ok(updatedBasket);
        }


        [HttpDelete]
        public async Task DeleteBasketAsync(string id)
        {
            await _basketRepository.DeleteBasketAsync(id);
        }


        [HttpDelete("ClearBasketAsync")]
        public async Task ClearBasketAsync(string id)
        {

            await _basketRepository.ClearBasketAsync(id);
        }
    }
}
