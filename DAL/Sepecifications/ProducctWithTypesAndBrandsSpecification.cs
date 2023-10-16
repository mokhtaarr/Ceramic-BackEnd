using DAL.Models;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Sepecifications
{
    public class ProducctWithTypesAndBrandsSpecification : BaseSpecification<MS_ItemCardView>
    {
        public ProducctWithTypesAndBrandsSpecification(ProductSpecParams productParams)
             : base(x =>
            (string.IsNullOrEmpty(productParams.Search) || x.ItemDescA.ToLower().Contains(productParams.Search) || x.ItemDescE.ToLower().Contains(productParams.Search)) &&
            (!productParams.BrandId.HasValue || x.BrandId == productParams.BrandId) &&
            (!productParams.TypeId.HasValue || x.ItemCategoryId == productParams.TypeId) 
            )
        {
            AddOrderBy(x => x.ItemDescA);
            AddOrderBy(x => x.ItemDescE);
            ApplyPaging(productParams.PageSize * (productParams.PageIndex - 1), productParams.PageSize);


            if (!string.IsNullOrEmpty(productParams.Sort))
            {
                switch (productParams.Sort)
                {
                    case "priceAsc":
                        AddOrderBy(p => p.FirstPrice);
                        break;

                    case "priceDesc":
                        AddOrderByDescending(p => p.FirstPrice);
                        break;
                    default:
                        AddOrderBy(p => p.ItemDescA);
                        AddOrderBy(p => p.ItemDescE);
                        break;


                }
            }
        }

        public ProducctWithTypesAndBrandsSpecification(int id):base(x=>x.ItemCardId==id)
        {

        }
    }
}
