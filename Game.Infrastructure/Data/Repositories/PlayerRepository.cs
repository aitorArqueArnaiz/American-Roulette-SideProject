using Microsoft.EntityFrameworkCore;

namespace Game.Infrastructure.Data.Repositories
{
    public class PlayerRepository : BaseRepository<Entity, DbContext>
    {
        public PlayerRepository(DbContextOptions<BaseRepository<Entity, DbContext>> options) : base(options)
        {
        }
    }
}
