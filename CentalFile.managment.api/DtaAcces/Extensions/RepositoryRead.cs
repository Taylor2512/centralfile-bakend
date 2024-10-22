using CentalFile.managment.api.DtaAcces.Extensions.Interfaces;

using Microsoft.EntityFrameworkCore;

using System.Linq.Expressions;

namespace CentalFile.managment.api.DtaAcces.Extensions
{
    public class RepositoryRead<T> : IRepositoryRed<T> where T : class
    {
        protected readonly ApplicationDbContext _context;

        public RepositoryRead(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<T?> GetByIdAsync<TId>(TId id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<IEnumerable<T>> GetWithIncludeAsync(
           Expression<Func<T, bool>>? predicate,
           params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = _context.Set<T>();

            if (includes != null)
            {
                query = includes.Aggregate(query, (current, include) => current.Include(include));
            }
            if (predicate != null)
            {
                query = query.Where(predicate);
            }

            return await query.ToListAsync();
        }

        public async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate)
        {
            return await _context.Set<T>().Where(predicate).ToListAsync();
        }

    }
}
