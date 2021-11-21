using Game.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Game.Infrastructure.Data.Repositories
{
    public class BetRepository : BaseRepository<Entity, DbContext>
    {
        public BetRepository(DbContextOptions<BaseRepository<Entity, DbContext>> options) : base(options)
        {
        }

        public void AddEntityAsync(Entity entity)
        {
            base.Add(entity);
        }
    }
}
