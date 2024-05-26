using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;
using TravelMapTurkey.Core.EntityBase;
using TravelMapTurkey.Data.Context;
using TravelMapTurkey.Data.Repositories.Abstractions;
using TravelMapTurkey.Entity.Entities;

namespace TravelMapTurkey.Data.Repositories.Concretes
{
    public class Repository<T> : IRepository<T> where T : class, IEntityBase, new()
    {
        private readonly AppDbContext dbContext;

        public Repository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        private DbSet<T> Table { get => dbContext.Set<T>(); }

        public async Task AddAsync(T entity)
        {
            await Table.AddAsync(entity);
        }

        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = Table;
            if (predicate != null)
            {
                query = query.Where(predicate);
            }

            if (includeProperties.Any())
            {
                foreach (var item in includeProperties)
                {
                    query = query.Include(item);
                }
            }

            return await query.ToListAsync();   
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> predicate)
        {
            return await Table.AnyAsync(predicate);
        }

        public async Task<int> CountAsync(Expression<Func<T, bool>> predicate = null)
        {
            if (predicate is not null)
            {
                return await Table.CountAsync(predicate);
            } else
            {
                return await Table.CountAsync();
            }
        }

        public async Task DeleteAsync(T entity)
        {
            await Task.Run(() => Table.Remove(entity));
        }

        

        //public async Task<T> GetAsync(Expression<Func<T, bool>> predicate, Expression<Func<T, object>> selectProperty, params Expression<Func<T, object>>[] includeProperties)
        //{
        //    IQueryable<T> query = Table;
        //    query = query.Where(predicate);
        //    if (includeProperties.Any())
        //    {
        //        foreach (var item in includeProperties)
        //        {
        //            query = query.Include(item);
        //        }
        //    }
        //    return await query.SingleAsync();
        //}

        public async Task<T> GetAsync(Expression<Func<T, bool>> predicate, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null)
        {
            IQueryable<T> queryable = Table;
            if (include is not null) queryable = include(queryable);
            //queryable.Where(predicate);
            return await queryable.SingleAsync(predicate);
        }


        public async Task<AppUser> GetAppUserWithCityReviewsAsync(Expression<Func<AppUser, bool>> predicate)
        {
            IQueryable<AppUser> query = dbContext.Users;

            // Kullanıcıyı bul ve Cities ile birlikte getir
            var user = await query.Include(u => u.Cities).FirstOrDefaultAsync(predicate);

            // Eğer kullanıcı bulunduysa, her bir City için CityReview'ları da getir
            if (user != null)
            {
                foreach (var city in user.Cities)
                {
                    dbContext.Entry(city).Reference(c => c.CityReview).Load();
                }
            }
            return user;
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await Table.FindAsync(id);
        }

        public async Task<T> UpdateAsync(T entity)
        {
            await Task.Run(() => Table.Update(entity));
            return entity;
        }
    }
}
