using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Sepecifications
{
    public class ProductWithFiltersForCountSepecification : BaseSpecification<MS_ItemCardView>
    {
        public ProductWithFiltersForCountSepecification(ProductSpecParams productParams)
            : base(x =>
             (string.IsNullOrEmpty(productParams.Search) || x.ItemDescA.ToLower().Contains(productParams.Search) || x.ItemDescE.ToLower().Contains(productParams.Search)) &&
             (!productParams.BrandId.HasValue || x.BrandId == productParams.BrandId) &&
             (!productParams.TypeId.HasValue || x.ItemCategoryId == productParams.TypeId))

        {

        }
    }
}
