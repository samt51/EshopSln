﻿using Eshop.Domain.Common;

namespace Eshop.Application.Interfaces.Repositories
{
    public interface IWriteRepository<T> where T : class, IBaseEntity, new()
    {
        Task<T> AddAsync(T entity);
        Task AddRangeAsync(IList<T> entities);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(T entity);
        Task HardDeleteRangeAsync(IList<T> entity);
    }
}
