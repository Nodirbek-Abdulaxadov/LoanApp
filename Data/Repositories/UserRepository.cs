using Data.Interfaces;
using Entities;

namespace Data.Repositories;
public class UserRepository : BaseRepository<User>, IUserInterface
{
    public UserRepository(AppDbContext dbContext) : base(dbContext)
    {
    }
}