using LG.Domain.Common;
using Microsoft.EntityFrameworkCore;

namespace LG.Data.Interfaces
{
    public interface IBaseRepository<TDbContext,TEntity,TKey> :IAsyncRepository<TDbContext,TEntity,TKey>
        where TDbContext:DbContext where TEntity : class,IEntity<TKey>
    {
    }
}
