using LG.Data.Interfaces;
using LG.Domain.Common;
using Microsoft.EntityFrameworkCore;

namespace LG.Data.EntityFramework
{
    public class BaseRepository<TDbContext, TEntity, TKey> : IBaseRepository<TDbContext, TEntity, TKey>
         where TDbContext : DbContext
        where TEntity : class, IEntity<TKey>
    {

        private TDbContext _dbContext;

        public BaseRepository(TDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async ValueTask<TEntity?> GetById(TKey id)
        {
            return await _dbContext.Set<TEntity>().FindAsync(id);
        }
        public IQueryable<TEntity> GetAll()
        {
            return _dbContext.Set<TEntity>().AsQueryable();
        }

        public async Task<TKey> Add(TEntity entity, string actor = "SYSTEM")
        {
            if (entity is IAuditable)
            {
                (entity as IAuditable).UpdatedAt = DateTime.UtcNow;
                (entity as IAuditable).CreatedAt = DateTime.UtcNow;

                (entity as IAuditable).CreatedBy = actor;
                (entity as IAuditable).UpdatedBy = actor;

            }
            await _dbContext.Set<TEntity>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity.Id;
        }

        public Task Update(TEntity entity, string actor = "SYSTEM")
        {
            if (entity is IAuditable)
            {
                (entity as IAuditable).UpdatedAt = DateTime.UtcNow;
                (entity as IAuditable).UpdatedBy = actor;
            }

            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChangesAsync();

            return Task.CompletedTask;
        }

        public Task SoftDelete(TEntity entity, string actor)
        {
            if (entity is BaseAuditableSoftDeleteEntity)
            {
                (entity as BaseAuditableSoftDeleteEntity).DeletedAt = DateTime.UtcNow;
                (entity as BaseAuditableSoftDeleteEntity).DeletedBy = actor;
            }

            _dbContext.Entry(entity).State = EntityState.Deleted;
            _dbContext.SaveChangesAsync();

            return Task.CompletedTask;
        }
    }
}
