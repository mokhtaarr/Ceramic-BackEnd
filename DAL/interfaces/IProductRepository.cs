using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.interfaces
{
    public interface IProductRepository
    {
        Task<MsItemCard> GetProductsByIdAsync(int id);
        Task<IReadOnlyList<MsItemCard>> GetProductsAsync();
        Task<IReadOnlyList<SrBrand>> GetProductBrandsAsync();
        Task<IReadOnlyList<MsItemCategory>> GetProductTypesAsync();
    }
}
