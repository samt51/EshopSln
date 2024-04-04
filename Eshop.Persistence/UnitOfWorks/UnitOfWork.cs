using Eshop.Application.Interfaces.Repositories;
using Eshop.Application.Interfaces.UnitOfWorks;
using Eshop.Persistence.Context;
using Eshop.Persistence.Repositories;

namespace Eshop.Persistence.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext dbContext;

        public UnitOfWork(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void Commit()
        {
            this.dbContext.Database.CommitTransaction();
        }

        public async ValueTask DisposeAsync() => await dbContext.DisposeAsync();

        public void OpenTransaction()
        {
            this.dbContext.Database.BeginTransaction();
        }

        public void RollBack()
        {
            this.dbContext.Database.RollbackTransaction();
        }

        public int Save() => dbContext.SaveChanges();
        public async Task<int> SaveAsync()
        {
      
            return await dbContext.SaveChangesAsync();
        }
        IReadRepository<T> IUnitOfWork.GetReadRepository<T>() => new ReadRepository<T>(dbContext);
        IWriteRepository<T> IUnitOfWork.GetWriteRepository<T>()
        {
            return new WriteRepository<T>(dbContext);
        }
    }
}
