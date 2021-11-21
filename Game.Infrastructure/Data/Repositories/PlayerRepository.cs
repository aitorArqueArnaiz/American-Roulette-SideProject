using Microsoft.EntityFrameworkCore;

namespace Game.Infrastructure.Data.Repositories
{
    public class PlayerRepository : BaseRepository<IEntity, DbContext>
    {
        public PlayerRepository(DbContextOptions<BaseRepository<IEntity, DbContext>> options) : base(options)
        {
        }
    }
}
