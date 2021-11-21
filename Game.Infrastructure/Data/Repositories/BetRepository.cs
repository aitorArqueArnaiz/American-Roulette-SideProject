
using Microsoft.EntityFrameworkCore;

namespace Game.Infrastructure.Data.Repositories
{
    public class BetRepository : BaseRepository
    {
        public BetRepository(DbContextOptions<BaseRepository> options) : base(options)
        {
        }
    }
}
