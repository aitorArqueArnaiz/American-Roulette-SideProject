using Game.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Game.Infrastructure.Data.Repositories
{
    public class BetRepository : BaseRepository<IEntity, DbContext>
    {
        public BetRepository(DbContextOptions<BaseRepository<IEntity, DbContext>> options) : base(options)
        {
        }
    }
}
