using Microsoft.EntityFrameworkCore;

namespace LG.Data.EntityFramework
{
    public abstract class BaseDbContext<TDbContext> : DbContext where TDbContext : DbContext
    {
        public BaseDbContext() : base()
        {
        }

    }
}
