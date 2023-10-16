using AutoMapper;
using DAL.Models;
using StoreApi.Dtos;

namespace StoreApi.Helpers
{
    public class ProductUrlResolver : IValueResolver<MS_ItemCardView, ProductDto, string>
    {
        private readonly IConfiguration _config;
        public ProductUrlResolver(IConfiguration config)
        {
            _config = config;
        }

        public string Resolve(MS_ItemCardView source, ProductDto destination, string destMember, ResolutionContext context)
        {
          
            if (!string.IsNullOrEmpty(source.TaxItemCode))
            {
                return _config["ApiUrl"] + source.TaxItemCode;
            }
            return null;
        }
    }
}
