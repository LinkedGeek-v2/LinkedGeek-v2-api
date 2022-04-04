using LG.Domain.Common;
using Microsoft.EntityFrameworkCore;

namespace LG.Data.Interfaces
{
    public interface IAsyncRepository<TDbContext, TEntity, TKey>
        where TDbContext : DbContext
        where TEntity : class, IEntity<TKey>
    {
        Task<TEntity> GetById(TKey id);
        Task<IReadOnlyList<TEntity>> GetAll();
        Task<TEntity> Add(TEntity entity);
        Task<TEntity> Update(TEntity entity);
        Task<TEntity> Delete(TEntity entity);

    }
}
