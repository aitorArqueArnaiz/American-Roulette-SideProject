using Game.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Game.Infrastructure.Data.Repositories
{
    public class BaseRepository<TEntity, TContext> : DbContext, IBaseRepository<TEntity>
        where TEntity : Entity
        where TContext : DbContext
    {
        public virtual DbSet<TEntity> Bets { get; set; }

        public BaseRepository(DbContextOptions<BaseRepository<TEntity, TContext>> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder.UseInMemoryDatabase("TestDB").EnableSensitiveDataLogging());
        }


        public Task<List<TEntity>> GetAll()
        {
            return this.Bets.AsQueryable().ToListAsync();
        }

        public void Add(TEntity entity)
        {
            this.Bets.Add(entity);
            base.SaveChanges();
        }

        public void AddRange(List<Entity> userBets)
        {
            this.Bets.AddRange((IEnumerable<TEntity>)userBets);
            base.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            this.Bets.Update(entity);
        }

        public void Delete(TEntity entity)
        {
            this.Bets.Remove(entity);
        }

        public Task<TEntity> Find(int id)
        {
            return this.Bets.SingleAsync(x => x.Id == id);
        }
    }
}
