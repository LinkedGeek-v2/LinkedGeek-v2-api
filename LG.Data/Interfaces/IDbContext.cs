namespace LG.Data.Interfaces
{
    internal interface IDbContext
    {
        int SaveChanges(bool acceptAllChangesOnSuccess);
        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess,CancellationToken cancellationToken = default);
    }
}
