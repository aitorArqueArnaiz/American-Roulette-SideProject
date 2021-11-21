using Microsoft.EntityFrameworkCore;

namespace Game.Infrastructure.Data.Repositories
{
    public class GameHistoryRepository : BaseRepository<Entity, DbContext>
    {
        public GameHistoryRepository(DbContextOptions<BaseRepository<Entity, DbContext>> options) : base(options)
        {
        }
    }
}
