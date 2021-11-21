using Microsoft.EntityFrameworkCore;

namespace Game.Infrastructure.Data.Repositories
{
    public class GameRepository : BaseRepository<IEntity, DbContext>
    {
        public GameRepository(DbContextOptions<BaseRepository<IEntity, DbContext>> options) : base(options)
        {
        }
    }
}
