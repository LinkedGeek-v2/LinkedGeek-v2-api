using LG.Data.Core.Interfaces;
using LG.Domain.Core.Models;

namespace LG.Data.Core.Repositories
{
    public class UserRepository : BaseRepository<CoreDbContext, User, Guid>, IUserRepository
    {
        public UserRepository(CoreDbContext context) : base(context)
        {

        }
    }
}
