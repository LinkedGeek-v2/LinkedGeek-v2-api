using LG.Domain.Common;
using Microsoft.EntityFrameworkCore;

namespace LG.Data.Interfaces
{
    public interface IAsyncRepository<TDbContext, TEntity, TKey>
        where TDbContext : DbContext
        where TEntity : class, IEntity<TKey>
    {
        ValueTask<TEntity?> GetById(TKey id);
        IQueryable<TEntity> GetAll();
        Task<TKey> Add(TEntity entity, string actor);
        Task Update(TEntity entity, string actor);
        Task SoftDelete(TEntity entity, string actor);
    }
}
