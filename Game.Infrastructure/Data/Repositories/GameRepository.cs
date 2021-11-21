using Microsoft.EntityFrameworkCore;

namespace Game.Infrastructure.Data.Repositories
{
    public class GameRepository : BaseRepository<Entity, DbContext>
    {
        public GameRepository(DbContextOptions<BaseRepository<Entity, DbContext>> options) : base(options)
        {
        }
    }
}
