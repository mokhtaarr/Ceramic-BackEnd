using DAL.interfaces;
using DAL.Models;
using DAL.Sepecifications;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastrucure.Data
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly MoDbContext _db;

        public GenericRepository(MoDbContext db)
        {
            _db = db;
        }
        public async Task<T> GetByIdAsync(int id)
        {
            return await _db.Set<T>().FindAsync(id);
        }

       

        public async Task<IReadOnlyList<T>> ListAllAsync()
        {
            return await _db.Set<T>().ToListAsync();
        }

        public async Task<T> GetEntityWithSpec(ISpecification<T> spec)
        {
            return await AppySpecification(spec).FirstOrDefaultAsync();

        }
        public async Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec)
        {
            return await AppySpecification(spec).ToListAsync();
        }

        public async Task<int> CountAsync(ISpecification<T> spec)
        {
            return await AppySpecification(spec).CountAsync();
        }
        private IQueryable<T> AppySpecification(ISpecification<T> spec)
        {
            return SpecificationEvaluator<T>.GetQuery(_db.Set<T>().AsQueryable(), spec);
        }

       
    }
}
