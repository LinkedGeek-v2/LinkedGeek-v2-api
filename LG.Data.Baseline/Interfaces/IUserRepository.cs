using LG.Domain.Core.Models;

namespace LG.Data.Core.Interfaces
{
    public interface IUserRepository : IBaseRepository<CoreDbContext, User, Guid>
    {
    }
}
