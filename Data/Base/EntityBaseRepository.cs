using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using MovieWebsite.Models;
using System.Linq.Expressions;

namespace MovieWebsite.Data.Base
{
    public class EntityBaseRepository<T> : IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        private readonly AppDbContext _Context;
        public EntityBaseRepository(AppDbContext Context)
        {
            _Context = Context;
        }
        public async Task AddAsync(T entity)
        {
            await _Context.Set<T>().AddAsync(entity);

            await _Context.SaveChangesAsync();

        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _Context.Set<T>().FirstOrDefaultAsync(n => n.Id == id);
            EntityEntry entityEntry = _Context.Entry<T>(entity);
            entityEntry.State = EntityState.Deleted;

            await _Context.SaveChangesAsync();

        }

        public async Task<IEnumerable<T>> GetAllAsync() => await _Context.Set<T>().ToListAsync();

        public async Task<IEnumerable<T>> GetAllAsync(params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _Context.Set<T>();
            query = includeProperties.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
            return await query.ToListAsync();

        }

        public async Task<T> GetByIdAsync(int id) => await _Context.Set<T>().FirstOrDefaultAsync(n => n.Id == id);

        public async Task UpdateAsync(int id, T entity)
        {
            EntityEntry entityEntry = _Context.Entry<T>(entity);
            entityEntry.State = EntityState.Modified;

            await _Context.SaveChangesAsync();
        }
    }
}
