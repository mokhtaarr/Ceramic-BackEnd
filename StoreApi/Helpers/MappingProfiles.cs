using AutoMapper;
using DAL.Models;
using StoreApi.Dtos;

namespace StoreApi.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<MsItemCard, ProductDto>();
        }
    }
}
