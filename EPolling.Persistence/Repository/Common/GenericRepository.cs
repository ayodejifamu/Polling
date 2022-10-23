using System.Linq.Expressions;
using EPolling.Persistence.AppDbContext;
using Microsoft.EntityFrameworkCore;
using EPolling.Domain.Common;
using EPolling.Application.Interface.Common;

namespace EPolling.Persistence.Repository.Common
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly PollingIdentityDbContext _context;
        public GenericRepository(PollingIdentityDbContext context)
        {
            _context = context;
            
        }
        public async Task<T> AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            return entity;
        }

        public async Task DeleteAsync(object id)
        {
            var datat = await _context.Set<T>().FindAsync(id);
            var entryState = _context.Entry<T>(datat);
            entryState.State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetbyIdAsync(object id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAllAsync(params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _context.Set<T>();
            query = includeProperties.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
            return await query.ToListAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            var entityEntry = _context.Entry<T>(entity);
            entityEntry.State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}