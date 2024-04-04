using Eshop.Application.Interfaces.Repositories;
using Eshop.Domain.Common;

namespace Eshop.Application.Interfaces.UnitOfWorks
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IReadRepository<T> GetReadRepository<T>() where T : class, IBaseEntity, new();
        IWriteRepository<T> GetWriteRepository<T>() where T : class, IBaseEntity, new();
        void OpenTransaction();
        Task<int> SaveAsync();
        void Commit();
        void RollBack();
    }
}
