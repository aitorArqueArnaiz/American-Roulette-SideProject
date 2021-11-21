using Game.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Game.Infrastructure.Data.Repositories
{
    public class BetRepository : BaseRepository<Entity, DbContext>, IBetRepository
    {

        public BetRepository(DbContextOptions<BaseRepository<Entity, DbContext>> options) : base(options)
        {
        }

        public void AddUserBet(Entity entity)
        {
            base.Add(entity);
        }

        public List<Entity> GetAllUserBets()
        {
            return base.GetAll().Result;
        }
    }
}
