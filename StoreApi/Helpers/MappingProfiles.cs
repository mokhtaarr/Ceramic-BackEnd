using AutoMapper;
using DAL.Identity;
using DAL.Models;
using StoreApi.Dtos;

namespace StoreApi.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<MsItemCard, ProductDto>();

            CreateMap<Address,AddressDto>().ReverseMap();
            CreateMap<EcomBasketItemDto,EcomBasketItem>().ReverseMap();
            CreateMap<EcomCustomerBasketDto, EcomCustomerBasket>().ReverseMap();
        }
    }
}
