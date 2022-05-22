using LG.Domain.Common;
using Microsoft.EntityFrameworkCore;

namespace LG.Data.Interfaces
{
    public interface IBaseRepository<TDbContext, TEntity, Guid> : IAsyncRepository<TDbContext, TEntity, Guid>
        where TDbContext : DbContext where TEntity : class, IEntity<Guid>
    {
    }
}
