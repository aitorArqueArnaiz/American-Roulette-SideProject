using Microsoft.EntityFrameworkCore;

namespace Game.Infrastructure.Data.Repositories
{
    public class GameHistoryRepository : BaseRepository<IEntity, DbContext>
    {
        public GameHistoryRepository(DbContextOptions<BaseRepository<IEntity, DbContext>> options) : base(options)
        {
        }
    }
}
