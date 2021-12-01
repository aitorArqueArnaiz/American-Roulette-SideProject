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
        /// <summary>
        /// The DbSet in memmory repository in order to save the player bets
        /// </summary>
        public virtual DbSet<TEntity> _playerBets { get; set; }

        public BaseRepository(DbContextOptions<BaseRepository<TEntity, TContext>> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder.UseInMemoryDatabase("TestDB").EnableSensitiveDataLogging());
        }


        public async Task<List<TEntity>> GetAll()
        {
            return await this._playerBets.AsQueryable().ToListAsync();
        }

        public void Add(TEntity entity)
        {
            this._playerBets.Add(entity);
            base.SaveChanges();
        }

        public void AddRange(List<Entity> userBets)
        {
            this._playerBets.AddRange((IEnumerable<TEntity>)userBets);
            base.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            this._playerBets.Update(entity);
            base.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            this._playerBets.Remove(entity);
            base.SaveChanges();
        }

        public async Task<TEntity> Find(int id)
        {
            return await this._playerBets.SingleAsync(x => x.Id == id);
        }
    }
}
