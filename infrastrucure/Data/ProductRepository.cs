using DAL.interfaces;
using DAL.Repository;
using DAL.Repository.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastrucure.Data
{
    public class ProductRepository : IProductRepository
    {
        private readonly MoDbContext _db;
        public ProductRepository(MoDbContext db)
        {
            _db = db;
        }


        public async Task<MsItemCard> GetProductsByIdAsync(int id)
        {
            return await _db.MsItemCards.FindAsync(id);
        }

        public async Task<IReadOnlyList<MsItemCard>> GetProductsAsync()
        {
            return await _db.MsItemCards.ToListAsync();
        }

        public async Task<IReadOnlyList<SrBrand>> GetProductBrandsAsync()
        {
            return await _db.SrBrands.ToListAsync();
        }

        public async Task<IReadOnlyList<MsItemCategory>> GetProductTypesAsync()
        {
            return await _db.MsItemCategories.ToListAsync();
        }
    }
}
