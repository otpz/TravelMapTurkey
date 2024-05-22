using TravelMapTurkey.Core.EntityBase;
using TravelMapTurkey.Data.Repositories.Abstractions;

namespace TravelMapTurkey.Data.UnitOfWorks
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IRepository<T> GetRepository<T>() where T : class, IEntityBase, new();
        Task<int> SaveAsync();
        int Save();
    }
}
