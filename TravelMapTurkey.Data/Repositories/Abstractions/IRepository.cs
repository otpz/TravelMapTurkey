using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;
using TravelMapTurkey.Core.EntityBase;
using TravelMapTurkey.Entity.Entities;

namespace TravelMapTurkey.Data.Repositories.Abstractions
{
    public interface IRepository<T> where T : class, IEntityBase, new()
    {
        public Task AddAsync(T entity);

        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null, params Expression<Func<T, object>>[] includeProperties);

        //Task<T> GetAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);
        Task<T> GetAsync(Expression<Func<T, bool>> predicate, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null);

        Task<T> GetByIdAsync(int id);

        Task<T> UpdateAsync(T entity);

        Task DeleteAsync(T entity);

        Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);

        Task<int> CountAsync(Expression<Func<T, bool>> predicate = null);

        Task<AppUser> GetAppUserWithCityReviewsAsync(Expression<Func<AppUser, bool>> predicate);
    }
}
